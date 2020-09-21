using Example.Core.DataAccess;
using Example.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.DataAccess.Abstract
{
    public interface IProjectDal : IEntityRepository<Project>
    {

    }
}
