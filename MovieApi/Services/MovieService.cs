using MovieApi.Helpers;
using MovieApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApi.Services
{
    public interface IMovieService
    {

    }
    public class MovieService :IMovieService
    {
        private readonly DataContext _dataContext;
        public MovieService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public ResultModel<string> UploadMovie()
        {
            var resultModel = new ResultModel<string>();

            return resultModel;
        }
    }
}
