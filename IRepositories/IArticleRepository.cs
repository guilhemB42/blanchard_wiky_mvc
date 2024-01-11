﻿using Entities;

namespace IRepositories
{
    public interface IArticleRepository
    {
        Task<List<Article>> GetAllAsync();
        Task<Article> GetByIdAsync(int id);
        Task<Article> CreateAsync(Article article);
        Task<Article> UpdateAsync(Article article);
        Task<Article> DeleteByIdAsync(int id);
    }
}
