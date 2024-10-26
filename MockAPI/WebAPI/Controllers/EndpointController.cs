﻿using Infrastructure.Interfaces;
using Infrastructure.Entities;
using Microsoft.AspNetCore.Mvc;
using Endpoint = Infrastructure.Entities.Endpoint;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class EndpointController : ControllerBase
    {
        private readonly IEndpointInternalRepo _repository;
        public EndpointController(IEndpointInternalRepo repo) 
        {
            _repository = repo;
        }

        [HttpPost]
        public async Task<IActionResult> AddEndpointAsync(Endpoint endpoint)
        {
            await _repository.AddEndpointAsync(endpoint);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteEndpointAsync(Guid endpointID)
        {
            await _repository.DeleteEndpointAsync(endpointID);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetEndpointsAsync()
        {
            var endpoints = await _repository.GetEndpointsAsync();
            return Ok(endpoints);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEndpointAsync(Endpoint endpoint)
        {
            await _repository.UpdateEndpointAsync(endpoint);
            return Ok();
        }
    }
}