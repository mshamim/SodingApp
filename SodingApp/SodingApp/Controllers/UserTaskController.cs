using SodingApp.Controllers.Resources;
using SodingApp.Repositories;
using System;
using System.Linq;
using System.Web.Mvc;

namespace SodingApp.Controllers
{
    public class UserTaskController : ControllerBase
    {
        internal readonly IUserTaskRepository userTaskRepository;
        

        public UserTaskController(IUserTaskRepository userTaskRepository)
        {
            this.userTaskRepository = userTaskRepository;
            
        }

        public ActionResult Index()
        {
            var viewModel = new UserTaskListViewModel();
            var userTasks = userTaskRepository.GetAll().OrderBy(p => p.Name);
            
            return View(new UserTaskListViewModel(userTasks));
        }

        public ActionResult Create()
        {
            
            return View(new UserTaskManageViewModel());
        }

        [HttpPost]
        public ActionResult Create(UserTaskManageViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var userTask = model.ToDalEntity();
                    userTaskRepository.InsertAndSubmit(userTask);

                    base.SetSuccessMessage("The userTask [{0}] has been created.", userTask.Name);
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    base.SetErrorMessage("Whoops! Couldn't create the new userTask. The error was [{0}]", ex.Message);
                }
            }
            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var userTask = userTaskRepository.GetById(id);

            if (userTask == null)
            {
                base.SetErrorMessage("User task with Id [{0}] does not exist", id.ToString());
                return RedirectToAction("Index");
            }


            return View(new UserTaskManageViewModel(userTask));
        }

        [HttpPost]
        public ActionResult Edit(UserTaskManageViewModel model)
        {
            if (ModelState.IsValid)
            {
                var application = userTaskRepository.GetById(model.Id);
                if (application == null) { throw new ArgumentException(string.Format("UserTask with Id [{0}] does not exist", model.Id)); }

                try
                {
                    model.ToDalEntity(application);
                    userTaskRepository.UpdateAndSubmit(application);

                    base.SetSuccessMessage("The user task [{0}] has been updated.", application.Name);
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    base.SetErrorMessage("Whoops! Couldn't update the application. The error was [{0}]", ex.Message);
                }
            }
            
            return View(model);
        }

        public ActionResult Delete(int id)
        {
            var userTask = userTaskRepository.GetById(id);

            if (userTask == null)
            {
                base.SetErrorMessage("User task with Id [{0}] does not exist", id.ToString());
                return RedirectToAction("Index");
            }

            return View(new UserTaskViewModel(userTask));
        }

        [HttpPost]
        public ActionResult Delete(UserTaskViewModel model)
        {
            var userTask = userTaskRepository.GetById(model.Id);
            if (userTask == null) { throw new ArgumentException(string.Format("User task with Id [{0}] does not exist", model.Id)); }

            try
            {
                userTaskRepository.DeleteAndSubmit(userTask);

                base.SetSuccessMessage("The user task has been deleted.");
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                base.SetErrorMessage("Whoops! Couldn't delete the task. The error was [{0}]", ex.Message);
            }

            return View(model);
        }

    }
}