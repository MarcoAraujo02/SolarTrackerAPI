﻿using Solar_Tracker.Models;

namespace Solar_Tracker.Repository.Interface
{
    public interface IEstabelecimentoRepository
    {

        Task<IEnumerable<Estabelecimento>> GetEstabelecimento();
        Task<Estabelecimento> GetEstabelecimento(int id);

        Task<Estabelecimento> AddEstabelecimento(Estabelecimento estabelecimento);
        Task<Estabelecimento> UpdateEstabelecimento(Estabelecimento estabelecimento);
        Task <Estabelecimento>DeleteEstabelecimento(int id);
    }
}
