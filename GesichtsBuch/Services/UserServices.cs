using GesichtsBuch.Models;
using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;

namespace GesichtsBuch.Services
{
   
    public class UserServices
    {
        public List<User> userList { get; set; } = new List<User>
        {
            new User
            {
                Id = 1,
                FirstName = "John",
                SecondName = "Doe",
                Email = "john.doe@example.com",
                Password = "password123",
                Country = "United States",
                City = "New York",
                IsActive = true,
                IsEmailConfirmed = true,
                Ratting = 4,
                ProfilePhoto = "profile1.jpg"
            },
            new User
            {
                Id = 2,
                FirstName = "Alice",
                SecondName = "Smith",
                Email = "alice.smith@example.com",
                Password = "securepass",
                Country = "Canada",
                City = "Toronto",
                IsActive = true,
                IsEmailConfirmed = true,
                Ratting = 5,
                ProfilePhoto = "profile2.jpg"
            },
            new User
            {
                Id = 3,
                FirstName = "Michael",
                SecondName = "Johnson",
                Email = "michael.j@example.com",
                Password = "mike123",
                Country = "United States",
                City = "Los Angeles",
                IsActive = true,
                IsEmailConfirmed = true,
                Ratting = 3,
                ProfilePhoto = "profile3.jpg"
            },
            new User
            {
                Id = 4,
                FirstName = "Sophia",
                SecondName = "Brown",
                Email = "sophia.b@example.com",
                Password = "brownie",
                Country = "United Kingdom",
                City = "London",
                IsActive = true,
                IsEmailConfirmed = false,
                Ratting = 2,
                ProfilePhoto = "profile4.jpg"
            },
            new User
            {
                Id = 5,
                FirstName = "David",
                SecondName = "Martinez",
                Email = "david.m@example.com",
                Password = "daveiscool",
                Country = "Spain",
                City = "Barcelona",
                IsActive = true,
                IsEmailConfirmed = true,
                Ratting = 4,
                ProfilePhoto = "profile5.jpg"
            },
            new User
            {
                Id = 6,
                FirstName = "Emma",
                SecondName = "Garcia",
                Email = "emma.g@example.com",
                Password = "12345",
                Country = "United States",
                City = "Chicago",
                IsActive = false,
                IsEmailConfirmed = true,
                Ratting = 1,
                ProfilePhoto = "profile6.jpg"
            },
            new User
            {
                Id = 7,
                FirstName = "James",
                SecondName = "Lopez",
                Email = "james.l@example.com",
                Password = "password123",
                Country = "United States",
                City = "Houston",
                IsActive = true,
                IsEmailConfirmed = true,
                Ratting = 4,
                ProfilePhoto = "profile7.jpg"
            },
            new User
            {
                Id = 8,
                FirstName = "Olivia",
                SecondName = "White",
                Email = "olivia.w@example.com",
                Password = "whitelily",
                Country = "Canada",
                City = "Vancouver",
                IsActive = true,
                IsEmailConfirmed = true,
                Ratting = 5,
                ProfilePhoto = "profile8.jpg"
            },
            new User
            {
                Id = 9,
                FirstName = "Daniel",
                SecondName = "Davis",
                Email = "daniel.d@example.com",
                Password = "dan1234",
                Country = "Australia",
                City = "Sydney",
                IsActive = true,
                IsEmailConfirmed = true,
                Ratting = 3,
                ProfilePhoto = "profile9.jpg"
            },
            new User
            {
                Id = 10,
                FirstName = "Ava",
                SecondName = "Harris",
                Email = "ava.h@example.com",
                Password = "password123",
                Country = "United States",
                City = "Miami",
                IsActive = true,
                IsEmailConfirmed = true,
                Ratting = 4,
                ProfilePhoto = "profile10.jpg"
            }
        };


        public List<User> GetAllUsers()
        {
            return userList;
        }

    }
}
