using Microsoft.AspNetCore.Mvc;
using MvcCoreVistasParciales.Models;
using MvcCoreVistasParciales.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreVistasParciales.ViewComponents
{
    public class MenuCochesViewComponent: ViewComponent
    {
        private RepositoryCoches repo;

        public MenuCochesViewComponent(RepositoryCoches repo)
        {
            this.repo = repo;
        }

        //AQUI PODEMOS TENER CUALQUIER CODIGO COMO HERRAMIENTA
        //OBLIGATORIO TENER EL MÉTODO InvokeAsync QUE SERÁ EL QUE LLAMAREMOS 
        //EN EL LAYOUT
        //ESTE MÉTODO CARGARÁ UN MODEL EN UNA VISTA PARA EL LAYOUT
        
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Coche> coches = this.repo.GetCoches();
            return View(coches);
        }
    }
}
