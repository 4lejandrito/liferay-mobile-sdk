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

#import "LRMDRActionService_v73.h"

/**
 * @author Bruno Farache
 */
@implementation LRMDRActionService_v73

- (NSDictionary *)addActionWithRuleGroupInstanceId:(long long)ruleGroupInstanceId nameMap:(NSDictionary *)nameMap descriptionMap:(NSDictionary *)descriptionMap type:(NSString *)type typeSettingsUnicodeProperties:(NSDictionary *)typeSettingsUnicodeProperties serviceContext:(LRJSONObjectWrapper *)serviceContext error:(NSError **)error {
	NSMutableDictionary *_params = [NSMutableDictionary dictionaryWithDictionary:@{
		@"ruleGroupInstanceId": @(ruleGroupInstanceId),
		@"nameMap": [self checkNull: nameMap],
		@"descriptionMap": [self checkNull: descriptionMap],
		@"type": [self checkNull: type],
		@"typeSettingsUnicodeProperties": [self checkNull: typeSettingsUnicodeProperties],
	}];

	[self mangleWrapperWithParams:_params name:@"serviceContext" className:@"com.liferay.portal.kernel.service.ServiceContext" wrapper:serviceContext];

	NSDictionary *_command = @{@"/mdr.mdraction/add-action": _params};

	return (NSDictionary *)[self.session invoke:_command error:error];
}

- (NSDictionary *)addActionWithRuleGroupInstanceId:(long long)ruleGroupInstanceId nameMap:(NSDictionary *)nameMap descriptionMap:(NSDictionary *)descriptionMap type:(NSString *)type typeSettings:(NSString *)typeSettings serviceContext:(LRJSONObjectWrapper *)serviceContext error:(NSError **)error {
	NSMutableDictionary *_params = [NSMutableDictionary dictionaryWithDictionary:@{
		@"ruleGroupInstanceId": @(ruleGroupInstanceId),
		@"nameMap": [self checkNull: nameMap],
		@"descriptionMap": [self checkNull: descriptionMap],
		@"type": [self checkNull: type],
		@"typeSettings": [self checkNull: typeSettings],
	}];

	[self mangleWrapperWithParams:_params name:@"serviceContext" className:@"com.liferay.portal.kernel.service.ServiceContext" wrapper:serviceContext];

	NSDictionary *_command = @{@"/mdr.mdraction/add-action": _params};

	return (NSDictionary *)[self.session invoke:_command error:error];
}

- (NSDictionary *)fetchActionWithActionId:(long long)actionId error:(NSError **)error {
	NSMutableDictionary *_params = [NSMutableDictionary dictionaryWithDictionary:@{
		@"actionId": @(actionId)
	}];

	NSDictionary *_command = @{@"/mdr.mdraction/fetch-action": _params};

	return (NSDictionary *)[self.session invoke:_command error:error];
}

- (void)deleteActionWithActionId:(long long)actionId error:(NSError **)error {
	NSMutableDictionary *_params = [NSMutableDictionary dictionaryWithDictionary:@{
		@"actionId": @(actionId)
	}];

	NSDictionary *_command = @{@"/mdr.mdraction/delete-action": _params};

	[self.session invoke:_command error:error];
}

- (NSDictionary *)updateActionWithActionId:(long long)actionId nameMap:(NSDictionary *)nameMap descriptionMap:(NSDictionary *)descriptionMap type:(NSString *)type typeSettings:(NSString *)typeSettings serviceContext:(LRJSONObjectWrapper *)serviceContext error:(NSError **)error {
	NSMutableDictionary *_params = [NSMutableDictionary dictionaryWithDictionary:@{
		@"actionId": @(actionId),
		@"nameMap": [self checkNull: nameMap],
		@"descriptionMap": [self checkNull: descriptionMap],
		@"type": [self checkNull: type],
		@"typeSettings": [self checkNull: typeSettings],
	}];

	[self mangleWrapperWithParams:_params name:@"serviceContext" className:@"com.liferay.portal.kernel.service.ServiceContext" wrapper:serviceContext];

	NSDictionary *_command = @{@"/mdr.mdraction/update-action": _params};

	return (NSDictionary *)[self.session invoke:_command error:error];
}

- (NSDictionary *)updateActionWithActionId:(long long)actionId nameMap:(NSDictionary *)nameMap descriptionMap:(NSDictionary *)descriptionMap type:(NSString *)type typeSettingsUnicodeProperties:(NSDictionary *)typeSettingsUnicodeProperties serviceContext:(LRJSONObjectWrapper *)serviceContext error:(NSError **)error {
	NSMutableDictionary *_params = [NSMutableDictionary dictionaryWithDictionary:@{
		@"actionId": @(actionId),
		@"nameMap": [self checkNull: nameMap],
		@"descriptionMap": [self checkNull: descriptionMap],
		@"type": [self checkNull: type],
		@"typeSettingsUnicodeProperties": [self checkNull: typeSettingsUnicodeProperties],
	}];

	[self mangleWrapperWithParams:_params name:@"serviceContext" className:@"com.liferay.portal.kernel.service.ServiceContext" wrapper:serviceContext];

	NSDictionary *_command = @{@"/mdr.mdraction/update-action": _params};

	return (NSDictionary *)[self.session invoke:_command error:error];
}

- (NSDictionary *)getActionWithActionId:(long long)actionId error:(NSError **)error {
	NSMutableDictionary *_params = [NSMutableDictionary dictionaryWithDictionary:@{
		@"actionId": @(actionId)
	}];

	NSDictionary *_command = @{@"/mdr.mdraction/get-action": _params};

	return (NSDictionary *)[self.session invoke:_command error:error];
}

@end