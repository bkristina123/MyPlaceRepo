using MyPlace.Data;
using MyPlace.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyPlace.Repositories
{
    public class ImageRepository : IImageRepository
    {
        private readonly MyPlaceDbContext context;

        public ImageRepository(MyPlaceDbContext context)
        {
            this.context = context;
        }

        public void CreateImage(UserImage userImage)
        {
            userImage.DateCreated = DateTime.Now;
            context.UserImages.Add(userImage);
            context.SaveChanges();
        }

        public IEnumerable<UserImage> GetAll()
        {
            return context.UserImages.ToList();
        }

        public UserImage GetById(int id)
        {
            return context.UserImages.FirstOrDefault(x => x.Id.Equals(id));
        }

        public IEnumerable<UserImage> GetByUsername(string username = null)
        {
            return context.UserImages.Where(x => 
            string.IsNullOrEmpty(username) || 
            x.Username.Contains(username))
                .ToList();
        }

        public void Remove(int id)
        {
            var image = new UserImage
            {
                Id = id
            };

            context.UserImages.Remove(image);
            context.SaveChanges();
        }

        public void Update(UserImage userImage)
        {
            context.UserImages.Update(userImage);
            context.SaveChanges();
        }
    }
}
