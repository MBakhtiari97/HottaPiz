using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HottaPiz.DataLayer.Entities.Common;

namespace HottaPiz.DataLayer.Repositories.Interfaces
{
    public interface IGenericRepository <TEntity> where TEntity : BaseEntity
    {

    }
}
