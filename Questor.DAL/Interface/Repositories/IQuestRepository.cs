﻿using Questor.DAL.Models;

namespace Questor.DAL.Interface.Repositories;

public interface IQuestRepository
{
    public Task Add(Quest quest);
    public Task Delete(int questId);
    public Task Update(Quest quest);
    public Task<Quest> GetQuestById(int questId);
    public Task<List<Quest>> GetQuestsByUserId(int userId);
    public Task<List<Quest>> GetAllPublicQuest();
    
}