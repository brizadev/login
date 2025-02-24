using System.Collections.Generic;
using System.Linq;
using backend.Data;
using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Services
{
    public class UsuarioService
    {
        private readonly ApplicationDbContext _context;

        public UsuarioService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Usuario> GetUsuarios()
        {
            return _context.Usuarios.ToList();
        }

        public Usuario? GetUsuario(int id)
        {
            return _context.Usuarios.Find(id);
        }

        public Usuario CreateUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            return usuario;
        }

        public bool UpdateUsuario(Usuario usuario)
        {
            if (!_context.Usuarios.Any(u => u.Id == usuario.Id))
            {
                return false;
            }

            _context.Entry(usuario).State = EntityState.Modified;
            _context.SaveChanges();
            return true;
        }

        public bool DeleteUsuario(int id)
        {
            var usuario = _context.Usuarios.Find(id);
            if (usuario == null)
            {
                return false;
            }

            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();
            return true;
        }
    }
}