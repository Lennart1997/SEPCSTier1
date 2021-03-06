using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEPCSTier1.Graphql;
using SEPCSTier1.Models;

namespace SEPCSTier1.Data
{
    public class ChatData : IChatData
    {
        private GraphqlClient graphqlClient;
        private List<Chat> chatList = new List<Chat>();


        public ChatData(GraphqlClient graphqlClient)
        {
            this.graphqlClient = graphqlClient;
        }

        public async Task<IList<Chat>> GetChat()
        {
            var result = await graphqlClient.GetChat.ExecuteAsync();

            chatList = result.Data.Chat.Select(chat => new Chat
            {
               // id = chat.Id,
                user_id = chat.User_id
            }).ToList();

            return chatList;
        }


        public async Task<Chat> GetChatByID(long Id)
        {
            return null;
        }


        public async void AddChat(Chat chat)
        {
            
        }

    }
}