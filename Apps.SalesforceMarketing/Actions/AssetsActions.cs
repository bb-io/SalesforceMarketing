using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Authentication;
using Blackbird.Applications.Sdk.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.SalesforceMarketing.Actions
{
    public class AssetsActions
    {
        //[Action("List all assets", Description = "List all assets")]
        //public async Task<GetChatUsersResponse> ListAssets(IEnumerable<AuthenticationCredentialsProvider> authenticationCredentialsProviders,
        //    [ActionParameter] GetChatUsersRequest input)
        //{
        //    var client = new MSTeamsClient(authenticationCredentialsProviders);
        //    var members = await client.Me.Chats[input.ChatId].Members.GetAsync();
        //    return new GetChatUsersResponse()
        //    {
        //        Members = members.Value.Select(m => new ChatMemberDto(m))
        //    };
        //}
    }
}
