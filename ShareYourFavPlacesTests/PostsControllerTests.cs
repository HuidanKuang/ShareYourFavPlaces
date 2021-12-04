using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShareYourFavPlaces.Controllers;
using ShareYourFavPlaces.Data;
using ShareYourFavPlaces.Models;
using System;
using System.Collections.Generic;

namespace ShareYourFavPlacesTests
{
    [TestClass]
    public class PostsControllerTests
    {
        //class level vars shared by all tests
        private ApplicationDbContext _context;

        //declare the controller
        PostsController controller;

        //declare a list a posts
        List<Post> posts = new List<Post>();

        [TestInitialize]
        public void TestInitialize()
        {
            //create in-memory db
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            _context = new ApplicationDbContext(options);

            //populate db with mock data
            var type = new ShareYourFavPlaces.Models.Type
            {
                TypeId = 200,
                Name = "sightseeing"
            };
            _context.Types.Add(type);

            posts.Add(new Post
            {
                PostId = 100,
                Title = "Quebec City",
                PlaceName = "Quebec City",
                Cost = 100,
                Experience = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. ",
                TypeId = 200,
                Type = type
            });

            posts.Add(new Post
            {
                PostId = 200,
                Title = "Banff",
                PlaceName = "Banff",
                Cost = 200,
                Experience = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. ",
                TypeId = 200,
                Type = type
            });

            posts.Add(new Post
            {
                PostId = 300,
                Title = "Blue Mountain",
                PlaceName = "Blue Mountain",
                Cost = 300,
                Experience = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. ",
                TypeId = 200,
                Type = type
            });

            foreach(var post in posts)
            {
                _context.Posts.Add(post);
            };

            _context.SaveChanges();

            //instantiate controller with db dependency
            controller = new PostsController(_context);

        }



        [TestMethod]
        public void EditLoadsEditView()
        {
            //arrange -- in TestInitialize

            //act
            var result = (ViewResult)controller.Edit(100).Result;
            //assert
            Assert.AreEqual("Edit", result.ViewName);
        }
    }
}
