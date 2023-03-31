﻿using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new SuccesResult();
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccesResult();
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccesDataResult<List<Color>>(_colorDal.GetAll());
        }

        public IDataResult<Color> GetById(int id)
        {
            return new SuccesDataResult<Color>(_colorDal.Get(c => c.Id == id));
        }

        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new SuccesResult();
        }
    }
}