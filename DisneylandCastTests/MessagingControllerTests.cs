using System;
using Xunit;
using DisneylandCast.Controllers;
using DisneylandCast.Models;
using DisneylandCast.Repositories;


namespace DisneylandCastTests
{
    public class MessagingControllerTests
    {
        [Fact]
        public void MessagingTest()
        {
            //Arrange
            var repo = new FakeUserRepository();
            var controller = new MessagingController(repo);
            var message = new Message
            {
                Sender = "Jack",
                Receiver = "Jane",
                MessageText = "How's it going?"
            };

            //Act
            controller.Messaging(message);

            //Assert
            Assert.Equal(2, repo.Users.Count);
            Assert.Equal("How's it going?", repo.Users[0].SentMessages[0].MessageText);
            Assert.Equal("How's it going?", repo.Users[1].ReceivedMessages[0].MessageText);
        }

        [Fact]
        public void ChooseUserTest()
        {
            //Arrange
            var repo = new FakeUserRepository();
            var controller = new MessagingController(repo);
            string username = "Jack";
            User user;

            //Act
            user = (User)controller.ChooseUser(username).Model;

            //Assert
            Assert.Single(repo.Users);
            Assert.Equal(user, repo.Users[0]);
            Assert.Equal("Jack", user.Name);
            Assert.Empty(user.SentMessages);
            Assert.Empty(user.ReceivedMessages);
        }

        [Fact]
        public void SendReplyTest()
        {
            //Arrange
            var repo = new FakeUserRepository();
            var controller = new MessagingController(repo);
            var message = new Message
            {
                MessageID = 1,
                Sender = "Jack",
                Receiver = "Jane",
                MessageText = "How's it going?",
                Sent = true
            };
            controller.Messaging(message);
            User user;

            //Act
            user = (User)controller.SendReply("1", "Things are going great!", true).Model;

            //Assert
            Assert.Equal("Jack", user.Name);
            Assert.Equal("Things are going great!", repo.Users[0].SentMessages[0].Replies[0].ReplyText);
            Assert.Equal("Things are going great!", repo.Users[1].ReceivedMessages[0].Replies[0].ReplyText);
        }
    }
}
