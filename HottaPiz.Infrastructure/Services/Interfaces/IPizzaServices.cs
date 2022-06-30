﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HottaPiz.DataLayer.DTOs.Pizza;
using HottaPiz.DataLayer.Entities.Pizza;

namespace HottaPiz.Infrastructure.Services.Interfaces
{
    public interface IPizzaServices
    {
        public Task<bool> UpdatePizzaAsync(UpdatePizzaVM pizzaDetails);
        public Pizza GetPizzaById(int pizzaId);
        public UpdatePizzaVM GetUpdatePizzaVMById(int pizzaId);
    }
}