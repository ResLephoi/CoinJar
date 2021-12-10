using CoinJarApi.Dto;
using CoinJarApi.Repo.IRepo;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoinJarApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class CoinJarController : ControllerBase
    {
        private readonly ICoinJar _coinJar;
        private readonly ICoin _coin;
        public CoinJarController(ICoinJar coinJar, ICoin coin)
        {
            _coinJar = coinJar;
            _coin = coin;
        }
        [HttpPost]
        public IActionResult AddCoin(CoinJarDto coinDto)
        {
            _coin.Amount = coinDto.Amount;
            _coin.Volume = coinDto.Volume;
            _coinJar.AddCoin(_coin);

            return Ok();
        }
        [HttpGet]
        public IActionResult GetTotalAmount()
        {
            var GetTotal = _coinJar.GetTotalAmount();
            return Ok(GetTotal);
        }
        [HttpDelete]
        public IActionResult Reset()
        {
            _coinJar.Reset();
            return Ok();
        }
    }
}
