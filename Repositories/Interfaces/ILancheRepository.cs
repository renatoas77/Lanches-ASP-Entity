﻿using SiteLanches.Context;
using SiteLanches.Models;

namespace SiteLanches.Repositories.Interfaces
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches { get; }
        IEnumerable<Lanche> LanchesPreferidos { get; }
        Lanche GetLancheById(int id);
    }
}
