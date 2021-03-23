using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;

namespace GameProject.Adapter
{
    class MernisServiceAdapter : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var result= client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.IdentityNumber),gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(),gamer.BirthYear.Year).Result;
            return result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
