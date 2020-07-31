using MyPlace.Data;
using MyPlace.ViewModels;

namespace MyPlace.Helpers
{
    public static class ModelConverter
    {
        public static UserImageViewModel ConvertToImageViewModel(this UserImage image)
        {
            return new UserImageViewModel
            {
                Id = image.Id,
                Username = image.Username,
                ImageUrl = image.ImageUrl,
                DateCreated = image.DateCreated
            };
        }

        public static UserImage ConvertToImageEntity(this UserImageViewModel image)
        {
            return new UserImage
            {
                Id = image.Id,
                Username = image.Username,
                ImageUrl = image.ImageUrl,
                DateCreated = image.DateCreated
            };
        }
    }
}
