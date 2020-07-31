using MyPlace.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyPlace.Repositories.Interfaces
{
    public interface IImageRepository
    {
        IEnumerable<UserImage> GetByUsername(string username);
        void CreateImage(UserImage userImage);
        IEnumerable<UserImage> GetAll();
        UserImage GetById(int id);
        void Update(UserImage userImage);
        void Remove(int id);
    }
}
