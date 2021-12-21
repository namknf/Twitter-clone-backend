﻿namespace Twitter_backend.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Twitter_backend.Models;

    [Route("api/[Profiles]")]
    [ApiController]
    public class ProfileController : Controller
    {
        private ProfilesContext _db;

        public ProfileController(ProfilesContext context)
        {
            _db = context;
        }

        public async Task<IActionResult> Create(Profile profile)
        {
            _db.Profiles.Add(profile);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
