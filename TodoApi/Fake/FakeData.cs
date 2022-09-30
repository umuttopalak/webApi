using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;
using Bogus;

namespace TodoApi.Fake
{
    public static class FakeData
    {
        private static List<User> _users;

        
        public static List<User> GetUsers()
        {
            if (_users == null)
            {
                _users = new Faker<User>()
                .RuleFor(u => u.Id, f => f.IndexFaker + 1)
                .RuleFor(u => u.FirstName, f => f.Name.FirstName())
                .RuleFor(u => u.LastName, f => f.Name.LastName())
                .RuleFor(u => u.Genre , f => f.Music.Genre())
                .RuleFor(u => u.Name , f=> f.Name.FirstName())
                .Generate(100);
            }
            
            return _users;
        }

        
    }
}
