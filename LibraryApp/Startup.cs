﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LibraryApp.Startup))]
namespace LibraryApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
