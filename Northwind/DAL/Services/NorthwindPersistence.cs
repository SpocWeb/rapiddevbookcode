﻿using System.Linq;
using Northwind.DAL.Interfaces;
using Northwind.DAL.Linq;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Northwind.DAL.Services
{
  public class NorthwindPersistence : IPersistence
  {
    private UnitOfWork2 _unitOfWork;
    private DataAccessAdapterBase _adapterToUse;

    public void Save(IEntity2 entity, bool commit = true)
    {
      if (commit)
        using (var adapter = Factories.CreateDataAccessAdapter())
        {
          adapter.SaveEntity(entity);
        }

      else
      {
        Uow.AddForSave(entity);
      }
    }

    private UnitOfWork2 Uow
    {
      get { return _unitOfWork ?? (_unitOfWork = new UnitOfWork2()); }
    }

    public void Delete(IEntity2 entity, bool commit = true)
    {
      if (commit)
        using (var adapter = Factories.CreateDataAccessAdapter())
        {
          adapter.DeleteEntity(entity);
        }
      else
      {
        Uow.AddForDelete(entity);
      }
    }

    public void Commit()
    {
      if (_unitOfWork != null)
        using (var adapter = Factories.CreateDataAccessAdapter())
          _unitOfWork.Commit(adapter);
    }

    public IQueryable<TEntity> GetQueryableForEntity<TEntity>() where TEntity : class
    {
      var linqMetaData = new LinqMetaData(GetAdapter());
      return linqMetaData.GetQueryableForEntity<TEntity>();
    }

    private DataAccessAdapterBase GetAdapter()
    {
      return _adapterToUse = _adapterToUse ?? Factories.CreateDataAccessAdapter();
    }
  }
}