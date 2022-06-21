using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterviewTrack.BusinessLayer;
using InterviewTracker.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using InterviewTracker.BusinessLayer.ViewModels;
using InterviewTrack.BusinessLayer.Interfaces;

namespace InterviewTracker.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class UserController : ControllerBase
  {
    /// <summary>
    /// creating a referance object of IUserInterviewTrackerServices
    /// </summary>
    private readonly IUserInterviewTrackerServices _userInterviewTS;

    /// <summary>
    /// injecting IUserInterviewTrackerServices in consructor to access all methods
    /// </summary>
    public UserController(IUserInterviewTrackerServices userInterviewTrackerServices)
    {
      _userInterviewTS = userInterviewTrackerServices;
    }
    //Get All Appliaction User on Load of API or calling this method
    // GET: api/User/GetBlogPost
    [HttpGet]
    public async Task<IEnumerable<ApplicationUser>> GetAllUser()
    {
      return await _userInterviewTS.GetAllUser();
    }
    /// <summary>
    /// Register a New User in MongoDb
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("RegisterUser")]
    public async Task<IActionResult> RegisterUser([FromBody] RegisterViewModel model)
    {
      //do code here
      throw new NotImplementedException();
    }
    /// <summary>
    /// Delete a user from MongoDb Collection
    /// </summary>
    /// <param name="UserId"></param>
    /// <returns></returns>
    [HttpDelete]
    [Route("DeleteUser/{UserId}")]
    public async Task<IActionResult> DeleteUser(string UserId)
    {
      //do code here
      throw new NotImplementedException();
    }
    /// <summary>
    /// Update User
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="user"></param>
    /// <returns></returns>
    [HttpPut]
    [Route("Updateuser/{UserId}")]
    public async Task<IActionResult> Updateuser(string userId, [FromBody] ApplicationUser user)
    {
      //do code here
      throw new NotImplementedException();
    }
  }
}
