using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ClinicaVeterinaria.App.Presentacion
{
    public class IniciarSesionModel : PageModel
    {
        public void OnGet()
        {
        }
        public String ImagePath
        {
            get
            {
                return "../images/user.jpg";
            }

        }
    }
}
