using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterviewTrack.BusinessLayer.Interfaces;
using InterviewTracker.BusinessLayer.Interfaces;
using InterviewTracker.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InterviewTracker.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DashboardController : ControllerBase
  {
    /// <summary>
    /// Creating Referancce variable of IInterviewTrackerServices and IUserInterviewTrackerServices
    /// and injecting Referance into constructor
    /// </summary>
    private readonly IInterviewTrackerServices _interviewTS;
    private readonly IUserInterviewTrackerServices _userTS;
    public DashboardController(IInterviewTrackerServices interviewTrackerServices,
        IUserInterviewTrackerServices userInterviewTrackerServices)
    {
      _interviewTS = interviewTrackerServices;
      _userTS = userInterviewTrackerServices;
    }
    //Get All interview
    [HttpGet]
    public async Task<IEnumerable<Interview>> AllInterviewAsync()
    {
      //do code here
      throw new NotImplementedException();
    }
    /// <summary>
    /// Delete a Interview from MongoDb Collection
    /// </summary>
    /// <param name="InterviewId"></param>
    /// <returns></returns>
    [HttpDelete]
    [Route("DeleteInterview/{InterviewId}")]
    public async Task<IActionResult> DeleteInterview(string InterviewId)
    {
      //do code here
      throw new NotImplementedException();
    }
    /// <summary>
    /// Update Interview
    /// </summary>
    /// <param name="InterviewId"></param>
    /// <param name="interview"></param>
    /// <returns>AllInterviewAsync method</returns>
    [HttpPut]
    [Route("Updateinterview/{InterviewId}")]
    public async Task<IActionResult> Updateinterview(string InterviewId, [FromBody] Interview interview)
    {
      //do code here
      throw new NotImplementedException();
    }
    /// <summary>
    /// Get a Interview by InterviewId
    /// </summary>
    /// <param name="InterviewId"></param>
    /// <returns>AllInterviewAsync method</returns>
    [HttpGet]
    [Route("Getinterview/{InterviewId}")]
    public async Task<IActionResult> Getinterview(string InterviewId)
    {
      //do code here
      throw new NotImplementedException();
    }
    /// <summary>
    /// Find a Interview by passing Interview name and Interviewer Name
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    [HttpGet]
    [Route("Searchinterview/{Name}")]
    public async Task<IActionResult> SearchInterview(string name)
    {
      //do code here
      throw new NotImplementedException();
    }
    /// <summary>
    /// Get Total no of Interview in Collection
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("TotalInterview")]
    public IActionResult TotalInterview()
    {
      //do code here
      throw new NotImplementedException();
    }
  }
}
