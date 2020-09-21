using Example.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Business.Abstract
{
    public interface IProjectService
    {
        void Add(Project project);
        void Update(Project project);
        void Delete(Project project);
        List<Project> GetUserProjects(AppUser user);
        List<Project> GetAllProjects();
    }
}
