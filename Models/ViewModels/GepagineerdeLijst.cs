using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio_Site.Models.ViewModels
{
    public class GepagineerdeLijst<ProjectBase> : List<ProjectBase>
    {
        public int Pagina { get; private set; }
        public int PaginaAantal { get; private set; }
        public GepagineerdeLijst(List<ProjectBase> lijstDeel, int totaalAantal, int pagina, int perPagina)
        {
            Pagina = pagina;
            PaginaAantal = (int)Math.Ceiling(totaalAantal / (double)perPagina);
            this.AddRange(lijstDeel);
        }
        //Methoden om te controleren of er een vorige/volgende pagina is
        public bool HeeftVorige() { return Pagina > 0; }
        public bool HeeftVolgende() { return Pagina < PaginaAantal - 1; }

        public static async Task<GepagineerdeLijst<ProjectBase>> CreateAsync(
        IQueryable<ProjectBase> lijst, int pagina, int perPagina)
        {
            return new GepagineerdeLijst<ProjectBase>(
                await lijst.Skip(pagina * perPagina).Take(perPagina).ToListAsync(),
                await lijst.CountAsync(),
                pagina,
                perPagina);
        }

    }
}
