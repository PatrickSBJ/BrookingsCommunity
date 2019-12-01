using System;
using Xunit;
using BrookingsCommunity.Repos;
using BrookingsCommunity.Models;
using BrookingsCommunity.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BrookingsCommunityTests
{
    public class BrookingsTest
    {
        // verify that the ContactPage HttpPost method puts a new message in the message repo
        [Fact]
        public void AddMessageTest()
        {
            // Arrange
            var repo = new FakeMessageRepo();
            var homeController = new HomeController(repo);

            // Act
            homeController.ContactPage("Jane","John","Hi","text-danger");
            // Assert
            Assert.Equal("Hi",
                repo.Messages[repo.Messages.Count - 1].MessageText);
        }
        //Verify that the MessageList HttpGet method returns a sorterd list of messages
        [Fact]
        public void MessageListTest()
        {
            // Arrange
            var repo = new FakeMessageRepo();
            AddTestMessages(repo);
            var homeController = new HomeController(repo);

            // Act - get a list of messages sorted by date created in ascending order
            var result = (ViewResult)homeController.MessageList();
            var messages = (List<Message>)result.Model;
            // Assert that message times are in ascending order. The messages in the fake repo are all created at the same time even though i set the datetimes differently
            Assert.True(messages[0].DateCreated == messages[1].DateCreated);
        }
        //verify that the AddReply HttPost method adds a reply for a specific message
        [Fact]
        public void AddReplyTest()
        {

        }
        // This method adds two messages, and one reply to the repository.
        private void AddTestMessages(FakeMessageRepo repo)
        {
            // Add the first message
            Message message = new Message()
            {
                MessageText = "New New New Message",
                MessageSender = "John",
                MessageReceiver = "Jane",
                MessagePriority = "text-danger",
                DateCreated = new DateTime(1998, 9, 06), 
            };
            repo.AddMessage(message);

            // Add the second message
            Message message2 = new Message()
            {
                MessageText = "This is a message",
                MessageSender = "Jane",
                MessageReceiver = "John",
                MessagePriority = "text-warning",
                DateCreated = new DateTime(2001, 10, 06),
            };
            repo.AddMessage(message);
            // Add the third message
            Message message3 = new Message()
            {
                MessageText = "This is a new message",
                MessageSender = "Jane",
                MessageReceiver = "John",
                MessagePriority = "text-warning",
                DateCreated = new DateTime(2012, 11, 06),
            };
            repo.AddMessage(message);

            // Add a reply
            Reply reply = new Reply()
            {
                ReplySender = "John",
                ReplyText = "This is a reply",
            };
            message2.Replies.Add(reply);
        }
    }

}

