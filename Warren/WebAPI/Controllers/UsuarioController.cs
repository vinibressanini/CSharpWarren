﻿using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    public class UsuarioController : GenericController<Usuario, UsuarioRepository>
    {
        public UsuarioController() : base(new UsuarioRepository())
        {

        }
    }
}
