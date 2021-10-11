using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ClinicaVeterinaria.App.Dominio;
using ClinicaVeterinaria.App.Persistencia;

namespace ClinicaVeterinaria.App.Presentacion.Pages
{
    public enum tipo
        {
            Administrador,
            Auxiliar,
            Dueño,
            Veterinario,
        }
    public class RegistroNuevoUsuarioModel : PageModel
    {
        //private readonly IRepositorioAdministrador repositorioAdministrador;
        //private readonly IRepositorioAuxiliar repositorioAuxiliar;
        //private readonly IRepositorioDueño repositorioDueño;
        //private readonly IRepositorioVeterinario repositorioVeterinario;
        public Administrador administrador { get; set; }
        public Auxiliar auxiliar { get; set; }
        public Dueño dueño { get; set; }
        public Veterinario veterinario { get; set; }
        public Object usuario { get; set; }
        
        public RegistroNuevoUsuarioModel()
        {
        }

        public void OnGet()
        {

            var opcion = Request.Form["lista"];
            switch (opcion)
            {
                case "Administrador":
                usuario = new Administrador();
                break;
                case "Auxiliar":
                usuario = new Auxiliar();
                break;
                case "Dueño":
                usuario = new Dueño();
                break;
                case "Veterinario" :
                usuario = new Veterinario();
                break;
            }
            Console.WriteLine("Esto es un " + usuario);
        }

        public IActionResult OnPost(Object usuario)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //repositorioMedico.addMedico(usuario);
                    return RedirectToPage("./MenuUsuario");
                }
                catch
                {
                    return RedirectToPage("../Error");
                }
            }
            else
            {
                return Page();
            }

        }
    }
}
