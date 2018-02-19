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

#import "LRSession.h"
#import "LRCookieCallback.h"

/**
 * @author Victor Galán
 */
@interface LRCookieSignIn : NSObject

+ (LRSession *)signInWithSession:(LRSession *)session
	callback:(id<LRCookieCallback>)callback;

+ (LRSession *)signInWithSession:(LRSession *)session
	callback:(id<LRCookieCallback>)callback
	challengeBlock: (void (^)(NSURLAuthenticationChallenge *challenge,
		void (^)(NSURLSessionAuthChallengeDisposition, NSURLCredential *))) challengeBlock;

@end
