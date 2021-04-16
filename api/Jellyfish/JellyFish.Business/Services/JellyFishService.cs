using JellyFish.Business.Models;
using System;

namespace JellyFish.Business.Services
{
    public class JellyFishService
    {
        public JellyFishService()
        {
        }

        public JellyFishCreateResponse Create(JellyFishCreateRequest request)
        {
            if(request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            return new JellyFishCreateResponse
            {
                Name = request.Name,
                Slug = request.Slug
            };
        }
    }
}