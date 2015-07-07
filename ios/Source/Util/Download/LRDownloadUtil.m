/**
 * Copyright (c) 2000-present Liferay, Inc. All rights reserved.
 *
 * This library is free software; you can redistribute it and/or modify it under
 * the terms of the GNU Lesser General Public License as published by the Free
 * Software Foundation; either version 2.1 of the License, or (at your option)
 * any later version.
 *
 * This library is distributed in the hope that it will be useful, but WITHOUT
 * ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS
 * FOR A PARTICULAR PURPOSE. See the GNU Lesser General Public License for more
 * details.
 */

#import "LRDownloadUtil.h"

#import "LRHttpUtil.h"
#import "LRPortalVersionUtil.h"

/**
 * @author Bruno Farache
 */
@implementation LRDownloadUtil

+ (void)downloadWithSession:(LRSession *)session
		URL:(NSString *)URL outputStream:(NSOutputStream *)outputStream
		progressDelegate:(id)progressDelegate {

	LRBasicAuthentication *auth = [LRDownloadUtil _getAuthentication:session];

	LRDownloadDelegate *delegate = [[LRDownloadDelegate alloc]
		initWithAuth:auth outputStream:outputStream
		progressDelegate:progressDelegate];

	NSMutableURLRequest *request = [LRHttpUtil getRequestWithSession:session
		URL:[NSURL URLWithString:URL]];

	[auth authenticate:request];

	NSURLConnection *connection = [[NSURLConnection alloc]
		initWithRequest:request delegate:delegate startImmediately:NO];

	[connection start];
}

+ (void)downloadWebDAVFileWithSession:(LRSession *)session
		portalVersion:(NSInteger)portalVersion
		groupFriendlyURL:(NSString *)groupFriendlyURL
		folderPath:(NSString *)folderPath fileTitle:(NSString *)fileTitle
		outputStream:(NSOutputStream *)outputStream
		progressDelegate:(id)progressDelegate {

	NSString *URL = [LRDownloadUtil getWebDAVFileURLWithSession:session
		portalVersion:portalVersion groupFriendlyURL:groupFriendlyURL
		folderPath:folderPath fileTitle:fileTitle];

	[LRDownloadUtil downloadWithSession:session URL:URL
		outputStream:outputStream progressDelegate:progressDelegate];
}

+ (NSString *)getWebDAVFileURLWithSession:(LRSession *)session
		portalVersion:(NSInteger)portalversion
		groupFriendlyURL:(NSString *)groupFriendlyURL
		folderPath:(NSString *)folderPath fileTitle:(NSString *)fileTitle {

	NSString *format = @"%@/%@";

	if (!folderPath) {
		format = @"%@%@";
	}

	NSString *webdavPath = [NSString stringWithFormat:format, folderPath,
		fileTitle];

	NSString *webdavPathEscaped = [LRHttpUtil
		escape:webdavPath include:@":?#[]@!$ &'()*+,;=\"<>%{}|\\^~`"
		ignore:@"/"];

	NSString *path = (portalversion < LR_VERSION_6_2) ? @"/api/secure" : @"";

	return [NSString
		stringWithFormat:@"%@%@/webdav%@/document_library/%@",
		session.server, path, groupFriendlyURL, webdavPathEscaped];
}

+ (LRBasicAuthentication *)_getAuthentication:(LRSession *)session {
	id<LRAuthentication> authentication = session.authentication;

	NSString *authClazz = NSStringFromClass([authentication class]);
	NSString *basicAuthClazz = NSStringFromClass([LRBasicAuthentication class]);

	if (!authentication) {
		[NSException raise:@"" format:@"Session authentication can't be null"];
	}

	if (![authClazz isEqualToString:basicAuthClazz]) {
		[NSException raise:@"" format:@"Can't download if authentication " \
			"implementation is not BasicAuthentication"];
	}

	return (LRBasicAuthentication *)authentication;
}

@end