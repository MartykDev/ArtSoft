﻿using Artsoft.DataAccess.Models.Entities;
using DaModels = Artsoft.DataAccess.Models;

namespace Artsoft.DataAccess.Repositories.Interfaces
{
    public interface IProgrammingLanguageRepository
    {
        Task<IEnumerable<ProgrammingLanguage>> GetAllAsync(CancellationToken cancellationToken);
    }
}