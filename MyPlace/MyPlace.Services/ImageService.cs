using MyPlace.Data;
using MyPlace.Repositories.Interfaces;
using MyPlace.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyPlace.Services
{
    public class ImageService : IImageService
    {
        private readonly IImageRepository imageRepository;

        public ImageService(IImageRepository imageRepository)
        {
            this.imageRepository = imageRepository;
        }

        public void CreateMovie(UserImage userImage)
        {
            imageRepository.CreateImage(userImage);
        }

        public void Delete(int id)
        {
            imageRepository.Remove(id);
        }

        public IEnumerable<UserImage> GetAll()
        {
            return imageRepository.GetAll();
        }

        public UserImage GetById(int id)
        {
            return imageRepository.GetById(id);
        }

        public IEnumerable<UserImage> GetByUsername(string username)
        {
           return imageRepository.GetByUsername(username);
        }

        public void Update(UserImage userImage)
        {
            imageRepository.Update(userImage);
        }
    }
}
