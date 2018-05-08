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

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Liferay.SDK.Service.V62.User
{
	public class UserService : ServiceBase
	{
		public UserService(ISession session)
			: base(session)
		{
		}

		public async Task AddGroupUsersAsync(long groupId, IEnumerable<long> userIds, IDictionary<string, object> serviceContext)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("userIds", userIds);
			_parameters.Add("serviceContext", serviceContext);

			var _command = new JsonObject()
			{
				{ "/user/add-group-users", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task AddOrganizationUsersAsync(long organizationId, IEnumerable<long> userIds)
		{
			var _parameters = new JsonObject();

			_parameters.Add("organizationId", organizationId);
			_parameters.Add("userIds", userIds);

			var _command = new JsonObject()
			{
				{ "/user/add-organization-users", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task AddPasswordPolicyUsersAsync(long passwordPolicyId, IEnumerable<long> userIds)
		{
			var _parameters = new JsonObject();

			_parameters.Add("passwordPolicyId", passwordPolicyId);
			_parameters.Add("userIds", userIds);

			var _command = new JsonObject()
			{
				{ "/user/add-password-policy-users", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task AddRoleUsersAsync(long roleId, IEnumerable<long> userIds)
		{
			var _parameters = new JsonObject();

			_parameters.Add("roleId", roleId);
			_parameters.Add("userIds", userIds);

			var _command = new JsonObject()
			{
				{ "/user/add-role-users", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task AddTeamUsersAsync(long teamId, IEnumerable<long> userIds)
		{
			var _parameters = new JsonObject();

			_parameters.Add("teamId", teamId);
			_parameters.Add("userIds", userIds);

			var _command = new JsonObject()
			{
				{ "/user/add-team-users", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task<IDictionary<string, object>> AddUserAsync(long companyId, bool autoPassword, string password1, string password2, bool autoScreenName, string screenName, string emailAddress, long facebookId, string openId, string locale, string firstName, string middleName, string lastName, int prefixId, int suffixId, bool male, int birthdayMonth, int birthdayDay, int birthdayYear, string jobTitle, IEnumerable<long> groupIds, IEnumerable<long> organizationIds, IEnumerable<long> roleIds, IEnumerable<long> userGroupIds, bool sendEmail, IDictionary<string, object> serviceContext)
		{
			var _parameters = new JsonObject();

			_parameters.Add("companyId", companyId);
			_parameters.Add("autoPassword", autoPassword);
			_parameters.Add("password1", password1);
			_parameters.Add("password2", password2);
			_parameters.Add("autoScreenName", autoScreenName);
			_parameters.Add("screenName", screenName);
			_parameters.Add("emailAddress", emailAddress);
			_parameters.Add("facebookId", facebookId);
			_parameters.Add("openId", openId);
			_parameters.Add("locale", locale);
			_parameters.Add("firstName", firstName);
			_parameters.Add("middleName", middleName);
			_parameters.Add("lastName", lastName);
			_parameters.Add("prefixId", prefixId);
			_parameters.Add("suffixId", suffixId);
			_parameters.Add("male", male);
			_parameters.Add("birthdayMonth", birthdayMonth);
			_parameters.Add("birthdayDay", birthdayDay);
			_parameters.Add("birthdayYear", birthdayYear);
			_parameters.Add("jobTitle", jobTitle);
			_parameters.Add("groupIds", groupIds);
			_parameters.Add("organizationIds", organizationIds);
			_parameters.Add("roleIds", roleIds);
			_parameters.Add("userGroupIds", userGroupIds);
			_parameters.Add("sendEmail", sendEmail);
			_parameters.Add("serviceContext", serviceContext);

			var _command = new JsonObject()
			{
				{ "/user/add-user", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IDictionary<string, object>)_obj;
		}

		public async Task<IDictionary<string, object>> AddUserAsync(long companyId, bool autoPassword, string password1, string password2, bool autoScreenName, string screenName, string emailAddress, long facebookId, string openId, string locale, string firstName, string middleName, string lastName, int prefixId, int suffixId, bool male, int birthdayMonth, int birthdayDay, int birthdayYear, string jobTitle, IEnumerable<long> groupIds, IEnumerable<long> organizationIds, IEnumerable<long> roleIds, IEnumerable<long> userGroupIds, IEnumerable<object> addresses, IEnumerable<object> emailAddresses, IEnumerable<object> phones, IEnumerable<object> websites, IEnumerable<object> announcementsDelivers, bool sendEmail, IDictionary<string, object> serviceContext)
		{
			var _parameters = new JsonObject();

			_parameters.Add("companyId", companyId);
			_parameters.Add("autoPassword", autoPassword);
			_parameters.Add("password1", password1);
			_parameters.Add("password2", password2);
			_parameters.Add("autoScreenName", autoScreenName);
			_parameters.Add("screenName", screenName);
			_parameters.Add("emailAddress", emailAddress);
			_parameters.Add("facebookId", facebookId);
			_parameters.Add("openId", openId);
			_parameters.Add("locale", locale);
			_parameters.Add("firstName", firstName);
			_parameters.Add("middleName", middleName);
			_parameters.Add("lastName", lastName);
			_parameters.Add("prefixId", prefixId);
			_parameters.Add("suffixId", suffixId);
			_parameters.Add("male", male);
			_parameters.Add("birthdayMonth", birthdayMonth);
			_parameters.Add("birthdayDay", birthdayDay);
			_parameters.Add("birthdayYear", birthdayYear);
			_parameters.Add("jobTitle", jobTitle);
			_parameters.Add("groupIds", groupIds);
			_parameters.Add("organizationIds", organizationIds);
			_parameters.Add("roleIds", roleIds);
			_parameters.Add("userGroupIds", userGroupIds);
			_parameters.Add("addresses", addresses);
			_parameters.Add("emailAddresses", emailAddresses);
			_parameters.Add("phones", phones);
			_parameters.Add("websites", websites);
			_parameters.Add("announcementsDelivers", announcementsDelivers);
			_parameters.Add("sendEmail", sendEmail);
			_parameters.Add("serviceContext", serviceContext);

			var _command = new JsonObject()
			{
				{ "/user/add-user", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IDictionary<string, object>)_obj;
		}

		public async Task AddUserGroupUsersAsync(long userGroupId, IEnumerable<long> userIds)
		{
			var _parameters = new JsonObject();

			_parameters.Add("userGroupId", userGroupId);
			_parameters.Add("userIds", userIds);

			var _command = new JsonObject()
			{
				{ "/user/add-user-group-users", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task<IDictionary<string, object>> AddUserWithWorkflowAsync(long companyId, bool autoPassword, string password1, string password2, bool autoScreenName, string screenName, string emailAddress, long facebookId, string openId, string locale, string firstName, string middleName, string lastName, int prefixId, int suffixId, bool male, int birthdayMonth, int birthdayDay, int birthdayYear, string jobTitle, IEnumerable<long> groupIds, IEnumerable<long> organizationIds, IEnumerable<long> roleIds, IEnumerable<long> userGroupIds, bool sendEmail, IDictionary<string, object> serviceContext)
		{
			var _parameters = new JsonObject();

			_parameters.Add("companyId", companyId);
			_parameters.Add("autoPassword", autoPassword);
			_parameters.Add("password1", password1);
			_parameters.Add("password2", password2);
			_parameters.Add("autoScreenName", autoScreenName);
			_parameters.Add("screenName", screenName);
			_parameters.Add("emailAddress", emailAddress);
			_parameters.Add("facebookId", facebookId);
			_parameters.Add("openId", openId);
			_parameters.Add("locale", locale);
			_parameters.Add("firstName", firstName);
			_parameters.Add("middleName", middleName);
			_parameters.Add("lastName", lastName);
			_parameters.Add("prefixId", prefixId);
			_parameters.Add("suffixId", suffixId);
			_parameters.Add("male", male);
			_parameters.Add("birthdayMonth", birthdayMonth);
			_parameters.Add("birthdayDay", birthdayDay);
			_parameters.Add("birthdayYear", birthdayYear);
			_parameters.Add("jobTitle", jobTitle);
			_parameters.Add("groupIds", groupIds);
			_parameters.Add("organizationIds", organizationIds);
			_parameters.Add("roleIds", roleIds);
			_parameters.Add("userGroupIds", userGroupIds);
			_parameters.Add("sendEmail", sendEmail);
			_parameters.Add("serviceContext", serviceContext);

			var _command = new JsonObject()
			{
				{ "/user/add-user-with-workflow", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IDictionary<string, object>)_obj;
		}

		public async Task<IDictionary<string, object>> AddUserWithWorkflowAsync(long companyId, bool autoPassword, string password1, string password2, bool autoScreenName, string screenName, string emailAddress, long facebookId, string openId, string locale, string firstName, string middleName, string lastName, int prefixId, int suffixId, bool male, int birthdayMonth, int birthdayDay, int birthdayYear, string jobTitle, IEnumerable<long> groupIds, IEnumerable<long> organizationIds, IEnumerable<long> roleIds, IEnumerable<long> userGroupIds, IEnumerable<object> addresses, IEnumerable<object> emailAddresses, IEnumerable<object> phones, IEnumerable<object> websites, IEnumerable<object> announcementsDelivers, bool sendEmail, IDictionary<string, object> serviceContext)
		{
			var _parameters = new JsonObject();

			_parameters.Add("companyId", companyId);
			_parameters.Add("autoPassword", autoPassword);
			_parameters.Add("password1", password1);
			_parameters.Add("password2", password2);
			_parameters.Add("autoScreenName", autoScreenName);
			_parameters.Add("screenName", screenName);
			_parameters.Add("emailAddress", emailAddress);
			_parameters.Add("facebookId", facebookId);
			_parameters.Add("openId", openId);
			_parameters.Add("locale", locale);
			_parameters.Add("firstName", firstName);
			_parameters.Add("middleName", middleName);
			_parameters.Add("lastName", lastName);
			_parameters.Add("prefixId", prefixId);
			_parameters.Add("suffixId", suffixId);
			_parameters.Add("male", male);
			_parameters.Add("birthdayMonth", birthdayMonth);
			_parameters.Add("birthdayDay", birthdayDay);
			_parameters.Add("birthdayYear", birthdayYear);
			_parameters.Add("jobTitle", jobTitle);
			_parameters.Add("groupIds", groupIds);
			_parameters.Add("organizationIds", organizationIds);
			_parameters.Add("roleIds", roleIds);
			_parameters.Add("userGroupIds", userGroupIds);
			_parameters.Add("addresses", addresses);
			_parameters.Add("emailAddresses", emailAddresses);
			_parameters.Add("phones", phones);
			_parameters.Add("websites", websites);
			_parameters.Add("announcementsDelivers", announcementsDelivers);
			_parameters.Add("sendEmail", sendEmail);
			_parameters.Add("serviceContext", serviceContext);

			var _command = new JsonObject()
			{
				{ "/user/add-user-with-workflow", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IDictionary<string, object>)_obj;
		}

		public async Task DeletePortraitAsync(long userId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("userId", userId);

			var _command = new JsonObject()
			{
				{ "/user/delete-portrait", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task DeleteRoleUserAsync(long roleId, long userId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("roleId", roleId);
			_parameters.Add("userId", userId);

			var _command = new JsonObject()
			{
				{ "/user/delete-role-user", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task DeleteUserAsync(long userId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("userId", userId);

			var _command = new JsonObject()
			{
				{ "/user/delete-user", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task<IDictionary<string, object>> GetCompanyUsersAsync(long companyId, int start, int end)
		{
			var _parameters = new JsonObject();

			_parameters.Add("companyId", companyId);
			_parameters.Add("start", start);
			_parameters.Add("end", end);

			var _command = new JsonObject()
			{
				{ "/user/get-company-users", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IDictionary<string, object>)_obj;
		}

		public async Task<long> GetCompanyUsersCountAsync(long companyId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("companyId", companyId);

			var _command = new JsonObject()
			{
				{ "/user/get-company-users-count", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (long)_obj;
		}

		public async Task<IDictionary<string, object>> GetCurrentUserAsync()
		{
			var _parameters = new JsonObject();

			var _command = new JsonObject()
			{
				{ "/user/get-current-user", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IDictionary<string, object>)_obj;
		}

		public async Task<IEnumerable<long>> GetGroupUserIdsAsync(long groupId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);

			var _command = new JsonObject()
			{
				{ "/user/get-group-user-ids", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			var _jsonArray = (JsonArray)_obj;

			return _jsonArray.Cast<long>();
		}

		public async Task<IDictionary<string, object>> GetGroupUsersAsync(long groupId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);

			var _command = new JsonObject()
			{
				{ "/user/get-group-users", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IDictionary<string, object>)_obj;
		}

		public async Task<IEnumerable<long>> GetOrganizationUserIdsAsync(long organizationId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("organizationId", organizationId);

			var _command = new JsonObject()
			{
				{ "/user/get-organization-user-ids", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			var _jsonArray = (JsonArray)_obj;

			return _jsonArray.Cast<long>();
		}

		public async Task<IDictionary<string, object>> GetOrganizationUsersAsync(long organizationId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("organizationId", organizationId);

			var _command = new JsonObject()
			{
				{ "/user/get-organization-users", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IDictionary<string, object>)_obj;
		}

		public async Task<IEnumerable<long>> GetRoleUserIdsAsync(long roleId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("roleId", roleId);

			var _command = new JsonObject()
			{
				{ "/user/get-role-user-ids", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			var _jsonArray = (JsonArray)_obj;

			return _jsonArray.Cast<long>();
		}

		public async Task<IDictionary<string, object>> GetUserByEmailAddressAsync(long companyId, string emailAddress)
		{
			var _parameters = new JsonObject();

			_parameters.Add("companyId", companyId);
			_parameters.Add("emailAddress", emailAddress);

			var _command = new JsonObject()
			{
				{ "/user/get-user-by-email-address", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IDictionary<string, object>)_obj;
		}

		public async Task<IDictionary<string, object>> GetUserByIdAsync(long userId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("userId", userId);

			var _command = new JsonObject()
			{
				{ "/user/get-user-by-id", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IDictionary<string, object>)_obj;
		}

		public async Task<IDictionary<string, object>> GetUserByScreenNameAsync(long companyId, string screenName)
		{
			var _parameters = new JsonObject();

			_parameters.Add("companyId", companyId);
			_parameters.Add("screenName", screenName);

			var _command = new JsonObject()
			{
				{ "/user/get-user-by-screen-name", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IDictionary<string, object>)_obj;
		}

		public async Task<IDictionary<string, object>> GetUserGroupUsersAsync(long userGroupId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("userGroupId", userGroupId);

			var _command = new JsonObject()
			{
				{ "/user/get-user-group-users", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IDictionary<string, object>)_obj;
		}

		public async Task<long> GetUserIdByEmailAddressAsync(long companyId, string emailAddress)
		{
			var _parameters = new JsonObject();

			_parameters.Add("companyId", companyId);
			_parameters.Add("emailAddress", emailAddress);

			var _command = new JsonObject()
			{
				{ "/user/get-user-id-by-email-address", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (long)_obj;
		}

		public async Task<long> GetUserIdByScreenNameAsync(long companyId, string screenName)
		{
			var _parameters = new JsonObject();

			_parameters.Add("companyId", companyId);
			_parameters.Add("screenName", screenName);

			var _command = new JsonObject()
			{
				{ "/user/get-user-id-by-screen-name", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (long)_obj;
		}

		public async Task<bool> HasGroupUserAsync(long groupId, long userId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("userId", userId);

			var _command = new JsonObject()
			{
				{ "/user/has-group-user", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (bool)_obj;
		}

		public async Task<bool> HasRoleUserAsync(long roleId, long userId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("roleId", roleId);
			_parameters.Add("userId", userId);

			var _command = new JsonObject()
			{
				{ "/user/has-role-user", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (bool)_obj;
		}

		public async Task<bool> HasRoleUserAsync(long companyId, string name, long userId, bool inherited)
		{
			var _parameters = new JsonObject();

			_parameters.Add("companyId", companyId);
			_parameters.Add("name", name);
			_parameters.Add("userId", userId);
			_parameters.Add("inherited", inherited);

			var _command = new JsonObject()
			{
				{ "/user/has-role-user", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (bool)_obj;
		}

		public async Task SetRoleUsersAsync(long roleId, IEnumerable<long> userIds)
		{
			var _parameters = new JsonObject();

			_parameters.Add("roleId", roleId);
			_parameters.Add("userIds", userIds);

			var _command = new JsonObject()
			{
				{ "/user/set-role-users", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task SetUserGroupUsersAsync(long userGroupId, IEnumerable<long> userIds)
		{
			var _parameters = new JsonObject();

			_parameters.Add("userGroupId", userGroupId);
			_parameters.Add("userIds", userIds);

			var _command = new JsonObject()
			{
				{ "/user/set-user-group-users", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task UnsetGroupTeamsUsersAsync(long groupId, IEnumerable<long> userIds)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("userIds", userIds);

			var _command = new JsonObject()
			{
				{ "/user/unset-group-teams-users", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task UnsetGroupUsersAsync(long groupId, IEnumerable<long> userIds, IDictionary<string, object> serviceContext)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("userIds", userIds);
			_parameters.Add("serviceContext", serviceContext);

			var _command = new JsonObject()
			{
				{ "/user/unset-group-users", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task UnsetOrganizationUsersAsync(long organizationId, IEnumerable<long> userIds)
		{
			var _parameters = new JsonObject();

			_parameters.Add("organizationId", organizationId);
			_parameters.Add("userIds", userIds);

			var _command = new JsonObject()
			{
				{ "/user/unset-organization-users", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task UnsetPasswordPolicyUsersAsync(long passwordPolicyId, IEnumerable<long> userIds)
		{
			var _parameters = new JsonObject();

			_parameters.Add("passwordPolicyId", passwordPolicyId);
			_parameters.Add("userIds", userIds);

			var _command = new JsonObject()
			{
				{ "/user/unset-password-policy-users", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task UnsetRoleUsersAsync(long roleId, IEnumerable<long> userIds)
		{
			var _parameters = new JsonObject();

			_parameters.Add("roleId", roleId);
			_parameters.Add("userIds", userIds);

			var _command = new JsonObject()
			{
				{ "/user/unset-role-users", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task UnsetTeamUsersAsync(long teamId, IEnumerable<long> userIds)
		{
			var _parameters = new JsonObject();

			_parameters.Add("teamId", teamId);
			_parameters.Add("userIds", userIds);

			var _command = new JsonObject()
			{
				{ "/user/unset-team-users", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task UnsetUserGroupUsersAsync(long userGroupId, IEnumerable<long> userIds)
		{
			var _parameters = new JsonObject();

			_parameters.Add("userGroupId", userGroupId);
			_parameters.Add("userIds", userIds);

			var _command = new JsonObject()
			{
				{ "/user/unset-user-group-users", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task<IDictionary<string, object>> UpdateAgreedToTermsOfUseAsync(long userId, bool agreedToTermsOfUse)
		{
			var _parameters = new JsonObject();

			_parameters.Add("userId", userId);
			_parameters.Add("agreedToTermsOfUse", agreedToTermsOfUse);

			var _command = new JsonObject()
			{
				{ "/user/update-agreed-to-terms-of-use", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IDictionary<string, object>)_obj;
		}

		public async Task<IDictionary<string, object>> UpdateEmailAddressAsync(long userId, string password, string emailAddress1, string emailAddress2, IDictionary<string, object> serviceContext)
		{
			var _parameters = new JsonObject();

			_parameters.Add("userId", userId);
			_parameters.Add("password", password);
			_parameters.Add("emailAddress1", emailAddress1);
			_parameters.Add("emailAddress2", emailAddress2);
			_parameters.Add("serviceContext", serviceContext);

			var _command = new JsonObject()
			{
				{ "/user/update-email-address", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IDictionary<string, object>)_obj;
		}

		public async Task<IDictionary<string, object>> UpdateIncompleteUserAsync(long companyId, bool autoPassword, string password1, string password2, bool autoScreenName, string screenName, string emailAddress, long facebookId, string openId, string locale, string firstName, string middleName, string lastName, int prefixId, int suffixId, bool male, int birthdayMonth, int birthdayDay, int birthdayYear, string jobTitle, bool updateUserInformation, bool sendEmail, IDictionary<string, object> serviceContext)
		{
			var _parameters = new JsonObject();

			_parameters.Add("companyId", companyId);
			_parameters.Add("autoPassword", autoPassword);
			_parameters.Add("password1", password1);
			_parameters.Add("password2", password2);
			_parameters.Add("autoScreenName", autoScreenName);
			_parameters.Add("screenName", screenName);
			_parameters.Add("emailAddress", emailAddress);
			_parameters.Add("facebookId", facebookId);
			_parameters.Add("openId", openId);
			_parameters.Add("locale", locale);
			_parameters.Add("firstName", firstName);
			_parameters.Add("middleName", middleName);
			_parameters.Add("lastName", lastName);
			_parameters.Add("prefixId", prefixId);
			_parameters.Add("suffixId", suffixId);
			_parameters.Add("male", male);
			_parameters.Add("birthdayMonth", birthdayMonth);
			_parameters.Add("birthdayDay", birthdayDay);
			_parameters.Add("birthdayYear", birthdayYear);
			_parameters.Add("jobTitle", jobTitle);
			_parameters.Add("updateUserInformation", updateUserInformation);
			_parameters.Add("sendEmail", sendEmail);
			_parameters.Add("serviceContext", serviceContext);

			var _command = new JsonObject()
			{
				{ "/user/update-incomplete-user", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IDictionary<string, object>)_obj;
		}

		public async Task<IDictionary<string, object>> UpdateLockoutByIdAsync(long userId, bool lockout)
		{
			var _parameters = new JsonObject();

			_parameters.Add("userId", userId);
			_parameters.Add("lockout", lockout);

			var _command = new JsonObject()
			{
				{ "/user/update-lockout-by-id", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IDictionary<string, object>)_obj;
		}

		public async Task<IDictionary<string, object>> UpdateOpenIdAsync(long userId, string openId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("userId", userId);
			_parameters.Add("openId", openId);

			var _command = new JsonObject()
			{
				{ "/user/update-open-id", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IDictionary<string, object>)_obj;
		}

		public async Task UpdateOrganizationsAsync(long userId, IEnumerable<long> organizationIds, IDictionary<string, object> serviceContext)
		{
			var _parameters = new JsonObject();

			_parameters.Add("userId", userId);
			_parameters.Add("organizationIds", organizationIds);
			_parameters.Add("serviceContext", serviceContext);

			var _command = new JsonObject()
			{
				{ "/user/update-organizations", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task<IDictionary<string, object>> UpdatePasswordAsync(long userId, string password1, string password2, bool passwordReset)
		{
			var _parameters = new JsonObject();

			_parameters.Add("userId", userId);
			_parameters.Add("password1", password1);
			_parameters.Add("password2", password2);
			_parameters.Add("passwordReset", passwordReset);

			var _command = new JsonObject()
			{
				{ "/user/update-password", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IDictionary<string, object>)_obj;
		}

		public async Task<IDictionary<string, object>> UpdatePortraitAsync(long userId, byte[] bytes)
		{
			var _parameters = new JsonObject();

			_parameters.Add("userId", userId);
			_parameters.Add("bytes", bytes);

			var _command = new JsonObject()
			{
				{ "/user/update-portrait", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IDictionary<string, object>)_obj;
		}

		public async Task<IDictionary<string, object>> UpdateReminderQueryAsync(long userId, string question, string answer)
		{
			var _parameters = new JsonObject();

			_parameters.Add("userId", userId);
			_parameters.Add("question", question);
			_parameters.Add("answer", answer);

			var _command = new JsonObject()
			{
				{ "/user/update-reminder-query", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IDictionary<string, object>)_obj;
		}

		public async Task<IDictionary<string, object>> UpdateScreenNameAsync(long userId, string screenName)
		{
			var _parameters = new JsonObject();

			_parameters.Add("userId", userId);
			_parameters.Add("screenName", screenName);

			var _command = new JsonObject()
			{
				{ "/user/update-screen-name", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IDictionary<string, object>)_obj;
		}

		public async Task<IDictionary<string, object>> UpdateStatusAsync(long userId, int status)
		{
			var _parameters = new JsonObject();

			_parameters.Add("userId", userId);
			_parameters.Add("status", status);

			var _command = new JsonObject()
			{
				{ "/user/update-status", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IDictionary<string, object>)_obj;
		}

		public async Task<IDictionary<string, object>> UpdateStatusAsync(long userId, int status, IDictionary<string, object> serviceContext)
		{
			var _parameters = new JsonObject();

			_parameters.Add("userId", userId);
			_parameters.Add("status", status);
			_parameters.Add("serviceContext", serviceContext);

			var _command = new JsonObject()
			{
				{ "/user/update-status", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IDictionary<string, object>)_obj;
		}

		public async Task<IDictionary<string, object>> UpdateUserAsync(long userId, string oldPassword, string newPassword1, string newPassword2, bool passwordReset, string reminderQueryQuestion, string reminderQueryAnswer, string screenName, string emailAddress, long facebookId, string openId, string languageId, string timeZoneId, string greeting, string comments, string firstName, string middleName, string lastName, int prefixId, int suffixId, bool male, int birthdayMonth, int birthdayDay, int birthdayYear, string smsSn, string aimSn, string facebookSn, string icqSn, string jabberSn, string msnSn, string mySpaceSn, string skypeSn, string twitterSn, string ymSn, string jobTitle, IEnumerable<long> groupIds, IEnumerable<long> organizationIds, IEnumerable<long> roleIds, IEnumerable<object> userGroupRoles, IEnumerable<long> userGroupIds, IDictionary<string, object> serviceContext)
		{
			var _parameters = new JsonObject();

			_parameters.Add("userId", userId);
			_parameters.Add("oldPassword", oldPassword);
			_parameters.Add("newPassword1", newPassword1);
			_parameters.Add("newPassword2", newPassword2);
			_parameters.Add("passwordReset", passwordReset);
			_parameters.Add("reminderQueryQuestion", reminderQueryQuestion);
			_parameters.Add("reminderQueryAnswer", reminderQueryAnswer);
			_parameters.Add("screenName", screenName);
			_parameters.Add("emailAddress", emailAddress);
			_parameters.Add("facebookId", facebookId);
			_parameters.Add("openId", openId);
			_parameters.Add("languageId", languageId);
			_parameters.Add("timeZoneId", timeZoneId);
			_parameters.Add("greeting", greeting);
			_parameters.Add("comments", comments);
			_parameters.Add("firstName", firstName);
			_parameters.Add("middleName", middleName);
			_parameters.Add("lastName", lastName);
			_parameters.Add("prefixId", prefixId);
			_parameters.Add("suffixId", suffixId);
			_parameters.Add("male", male);
			_parameters.Add("birthdayMonth", birthdayMonth);
			_parameters.Add("birthdayDay", birthdayDay);
			_parameters.Add("birthdayYear", birthdayYear);
			_parameters.Add("smsSn", smsSn);
			_parameters.Add("aimSn", aimSn);
			_parameters.Add("facebookSn", facebookSn);
			_parameters.Add("icqSn", icqSn);
			_parameters.Add("jabberSn", jabberSn);
			_parameters.Add("msnSn", msnSn);
			_parameters.Add("mySpaceSn", mySpaceSn);
			_parameters.Add("skypeSn", skypeSn);
			_parameters.Add("twitterSn", twitterSn);
			_parameters.Add("ymSn", ymSn);
			_parameters.Add("jobTitle", jobTitle);
			_parameters.Add("groupIds", groupIds);
			_parameters.Add("organizationIds", organizationIds);
			_parameters.Add("roleIds", roleIds);
			_parameters.Add("userGroupRoles", userGroupRoles);
			_parameters.Add("userGroupIds", userGroupIds);
			_parameters.Add("serviceContext", serviceContext);

			var _command = new JsonObject()
			{
				{ "/user/update-user", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IDictionary<string, object>)_obj;
		}

		public async Task<IDictionary<string, object>> UpdateUserAsync(long userId, string oldPassword, string newPassword1, string newPassword2, bool passwordReset, string reminderQueryQuestion, string reminderQueryAnswer, string screenName, string emailAddress, long facebookId, string openId, string languageId, string timeZoneId, string greeting, string comments, string firstName, string middleName, string lastName, int prefixId, int suffixId, bool male, int birthdayMonth, int birthdayDay, int birthdayYear, string smsSn, string aimSn, string facebookSn, string icqSn, string jabberSn, string msnSn, string mySpaceSn, string skypeSn, string twitterSn, string ymSn, string jobTitle, IEnumerable<long> groupIds, IEnumerable<long> organizationIds, IEnumerable<long> roleIds, IEnumerable<object> userGroupRoles, IEnumerable<long> userGroupIds, IEnumerable<object> addresses, IEnumerable<object> emailAddresses, IEnumerable<object> phones, IEnumerable<object> websites, IEnumerable<object> announcementsDelivers, IDictionary<string, object> serviceContext)
		{
			var _parameters = new JsonObject();

			_parameters.Add("userId", userId);
			_parameters.Add("oldPassword", oldPassword);
			_parameters.Add("newPassword1", newPassword1);
			_parameters.Add("newPassword2", newPassword2);
			_parameters.Add("passwordReset", passwordReset);
			_parameters.Add("reminderQueryQuestion", reminderQueryQuestion);
			_parameters.Add("reminderQueryAnswer", reminderQueryAnswer);
			_parameters.Add("screenName", screenName);
			_parameters.Add("emailAddress", emailAddress);
			_parameters.Add("facebookId", facebookId);
			_parameters.Add("openId", openId);
			_parameters.Add("languageId", languageId);
			_parameters.Add("timeZoneId", timeZoneId);
			_parameters.Add("greeting", greeting);
			_parameters.Add("comments", comments);
			_parameters.Add("firstName", firstName);
			_parameters.Add("middleName", middleName);
			_parameters.Add("lastName", lastName);
			_parameters.Add("prefixId", prefixId);
			_parameters.Add("suffixId", suffixId);
			_parameters.Add("male", male);
			_parameters.Add("birthdayMonth", birthdayMonth);
			_parameters.Add("birthdayDay", birthdayDay);
			_parameters.Add("birthdayYear", birthdayYear);
			_parameters.Add("smsSn", smsSn);
			_parameters.Add("aimSn", aimSn);
			_parameters.Add("facebookSn", facebookSn);
			_parameters.Add("icqSn", icqSn);
			_parameters.Add("jabberSn", jabberSn);
			_parameters.Add("msnSn", msnSn);
			_parameters.Add("mySpaceSn", mySpaceSn);
			_parameters.Add("skypeSn", skypeSn);
			_parameters.Add("twitterSn", twitterSn);
			_parameters.Add("ymSn", ymSn);
			_parameters.Add("jobTitle", jobTitle);
			_parameters.Add("groupIds", groupIds);
			_parameters.Add("organizationIds", organizationIds);
			_parameters.Add("roleIds", roleIds);
			_parameters.Add("userGroupRoles", userGroupRoles);
			_parameters.Add("userGroupIds", userGroupIds);
			_parameters.Add("addresses", addresses);
			_parameters.Add("emailAddresses", emailAddresses);
			_parameters.Add("phones", phones);
			_parameters.Add("websites", websites);
			_parameters.Add("announcementsDelivers", announcementsDelivers);
			_parameters.Add("serviceContext", serviceContext);

			var _command = new JsonObject()
			{
				{ "/user/update-user", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IDictionary<string, object>)_obj;
		}
	}
}