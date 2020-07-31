using MyPlace.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyPlace.Services.Interfaces
{
    public interface IImageService
    {
        IEnumerable<UserImage> GetByUsername(string username);
        void CreateMovie(UserImage userImage);
        IEnumerable<UserImage> GetAll();
        UserImage GetById(int id);
        void Update(UserImage userImage);
        void Delete(int id);
    }
}
