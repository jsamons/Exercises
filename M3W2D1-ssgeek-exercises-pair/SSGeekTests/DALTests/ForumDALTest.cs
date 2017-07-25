using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SSGeek.Controllers;
using SSGeek.Models;
using System.Web.Mvc;
using SSGeek.DAL;
using System.Collections.Generic;
using System.Transactions;
using System.Data.SqlClient;

namespace SSGeekTests.DALTests
{
    [TestClass]
    public class ForumDALTest
    {

        private TransactionScope tran;

        [TestInitialize]
        public void Initialize()
        {
            tran = new TransactionScope();
        }

        [TestCleanup]
        public void Cleanup()
        {
            tran.Dispose();
        }

        [TestMethod]
        public void GetallPostsTest()
        {
            ForumPostSqlDAL test = new ForumPostSqlDAL();
            List<ForumPost> testList = test.GetAllPosts();

            Assert.IsNotNull(testList);
        }

        [TestMethod]
        public void SaveNewPostsTest()
        {
            ForumPost newPost = new ForumPost();
            newPost.Message = "Hello_World";
            newPost.Subject = "Hello";
            newPost.Username = "FooBar";

            ForumPostSqlDAL forumPost = new ForumPostSqlDAL();
            bool testBool = forumPost.SaveNewPost(newPost);

            Assert.AreEqual(true, testBool);
        }



    }
}
