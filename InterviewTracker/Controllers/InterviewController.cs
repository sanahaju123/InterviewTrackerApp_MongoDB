using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterviewTracker.BusinessLayer.Interfaces;
using InterviewTracker.BusinessLayer.ViewModels;
using InterviewTracker.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InterviewTracker.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class InterviewController : ControllerBase
  {
    /// <summary>
    /// creating a referance object of IInterviewTrackerServices
    /// </summary>
    private readonly IInterviewTrackerServices _interviewTS;

    /// <summary>
    /// injecting IInterviewTrackerServices in consructor to access all methods
    /// </summary>
    public InterviewController(IInterviewTrackerServices interviewTrackerServices)
    {
      _interviewTS = interviewTrackerServices;
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
    /// <summary>
    /// Post method of AddNewInterview, to create a new interview
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("AddInterview")]
    public async Task<IActionResult> AddNewInterview([FromBody] AddInterviewViewModel model)
    {
      //do code here
      throw new NotImplementedException();
    }
  }
}
