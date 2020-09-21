using Example.Core.DataAccess.EntityFramework;
using Example.DataAccess.Abstract;
using Example.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.DataAccess.Concrete.EntityFramework
{
    public class EfProjectDal : EfEntityRepositoryBase<Project, ExampleContext>, IProjectDal
    {
    }
}
