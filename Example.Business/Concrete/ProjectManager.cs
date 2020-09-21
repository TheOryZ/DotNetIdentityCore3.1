using Example.Business.Abstract;
using Example.DataAccess.Abstract;
using Example.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Business.Concrete
{
    public class ProjectManager : IProjectService
    {
        private readonly IProjectDal _projectDal;

        public ProjectManager(IProjectDal projectDal)
        {
            _projectDal = projectDal;
        }

        public void Add(Project project)
        {
            _projectDal.Add(project);
        }

        public void Update(Project project)
        {
            _projectDal.Update(project);
        }

        public void Delete(Project project)
        {
            _projectDal.Delete(project);
        }

        public List<Project> GetAllProjects()
        {
            return _projectDal.GetList();
        }

        public List<Project> GetUserProjects(AppUser user)
        {
            return _projectDal.GetList(p => p.OwnerId == user.Id);
        }
    }
}
