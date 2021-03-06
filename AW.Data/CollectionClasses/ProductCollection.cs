﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.2
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml;
#if !CF
using System.Runtime.Serialization;
#endif

using AW.Data.EntityClasses;
using AW.Data.FactoryClasses;
using AW.Data.DaoClasses;
using AW.Data.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.CollectionClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Collection class for storing and retrieving collections of ProductEntity objects. </summary>
	[Serializable]
	public partial class ProductCollection : EntityCollectionBase<ProductEntity>
	{
		/// <summary> CTor</summary>
		public ProductCollection():base(new ProductEntityFactory())
		{
		}

		/// <summary> CTor</summary>
		/// <param name="initialContents">The initial contents of this collection.</param>
		public ProductCollection(IEnumerable<ProductEntity> initialContents):base(new ProductEntityFactory())
		{
			AddRange(initialContents);
		}

		/// <summary> CTor</summary>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public ProductCollection(IEntityFactory entityFactoryToUse):base(entityFactoryToUse)
		{
		}

		/// <summary> Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ProductCollection(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}


		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which have data in common with the specified related Entities.
		/// If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		/// <param name="productModelInstance">ProductModelEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="productSubcategoryInstance">ProductSubcategoryEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="sizeUnitMeasureInstance">UnitMeasureEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="weightUnitMeasureInstance">UnitMeasureEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public bool GetMultiManyToOne(IEntity productModelInstance, IEntity productSubcategoryInstance, IEntity sizeUnitMeasureInstance, IEntity weightUnitMeasureInstance)
		{
			return GetMultiManyToOne(productModelInstance, productSubcategoryInstance, sizeUnitMeasureInstance, weightUnitMeasureInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, null, 0, 0);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which have data in common with the specified related Entities.
		/// If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		/// <param name="productModelInstance">ProductModelEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="productSubcategoryInstance">ProductSubcategoryEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="sizeUnitMeasureInstance">UnitMeasureEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="weightUnitMeasureInstance">UnitMeasureEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="filter">Extra filter to limit the resultset. Predicate expression can be null, in which case it will be ignored.</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public bool GetMultiManyToOne(IEntity productModelInstance, IEntity productSubcategoryInstance, IEntity sizeUnitMeasureInstance, IEntity weightUnitMeasureInstance, IPredicateExpression filter)
		{
			return GetMultiManyToOne(productModelInstance, productSubcategoryInstance, sizeUnitMeasureInstance, weightUnitMeasureInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, filter, 0, 0);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which have data in common with the specified related Entities.
		/// If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		/// <param name="productModelInstance">ProductModelEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="productSubcategoryInstance">ProductSubcategoryEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="sizeUnitMeasureInstance">UnitMeasureEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="weightUnitMeasureInstance">UnitMeasureEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="filter">Extra filter to limit the resultset. Predicate expression can be null, in which case it will be ignored.</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public bool GetMultiManyToOne(IEntity productModelInstance, IEntity productSubcategoryInstance, IEntity sizeUnitMeasureInstance, IEntity weightUnitMeasureInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPredicateExpression filter)
		{
			return GetMultiManyToOne(productModelInstance, productSubcategoryInstance, sizeUnitMeasureInstance, weightUnitMeasureInstance, maxNumberOfItemsToReturn, sortClauses, filter, 0, 0);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which have data in common with the specified related Entities.
		/// If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		/// <param name="productModelInstance">ProductModelEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="productSubcategoryInstance">ProductSubcategoryEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="sizeUnitMeasureInstance">UnitMeasureEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="weightUnitMeasureInstance">UnitMeasureEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="filter">Extra filter to limit the resultset. Predicate expression can be null, in which case it will be ignored.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToOne(IEntity productModelInstance, IEntity productSubcategoryInstance, IEntity sizeUnitMeasureInstance, IEntity weightUnitMeasureInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPredicateExpression filter, int pageNumber, int pageSize)
		{
			bool validParameters = false;
			validParameters |= (productModelInstance!=null);
			validParameters |= (productSubcategoryInstance!=null);
			validParameters |= (sizeUnitMeasureInstance!=null);
			validParameters |= (weightUnitMeasureInstance!=null);
			if(!validParameters)
			{
				return GetMulti(filter, maxNumberOfItemsToReturn, sortClauses, null, pageNumber, pageSize);
			}
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateProductDAO().GetMulti(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, filter, productModelInstance, productSubcategoryInstance, sizeUnitMeasureInstance, weightUnitMeasureInstance, pageNumber, pageSize);
		}

		/// <summary> Deletes from the persistent storage all Product entities which have data in common with the specified related Entities. If one is omitted, that entity is not used as a filter.</summary>
		/// <remarks>Runs directly on the persistent storage. It will not delete entity objects from the current collection.</remarks>
		/// <param name="productModelInstance">ProductModelEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="productSubcategoryInstance">ProductSubcategoryEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="sizeUnitMeasureInstance">UnitMeasureEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="weightUnitMeasureInstance">UnitMeasureEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		public int DeleteMultiManyToOne(IEntity productModelInstance, IEntity productSubcategoryInstance, IEntity sizeUnitMeasureInstance, IEntity weightUnitMeasureInstance)
		{
			return DAOFactory.CreateProductDAO().DeleteMulti(this.Transaction, productModelInstance, productSubcategoryInstance, sizeUnitMeasureInstance, weightUnitMeasureInstance);
		}

		/// <summary> Updates in the persistent storage all Product entities which have data in common with the specified related Entities. If one is omitted, that entity is not used as a filter.
		/// Which fields are updated in those matching entities depends on which fields are <i>changed</i> in the passed in entity entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		/// <param name="entityWithNewValues">ProductEntity instance which holds the new values for the matching entities to update. Only changed fields are taken into account</param>
		/// <param name="productModelInstance">ProductModelEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="productSubcategoryInstance">ProductSubcategoryEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="sizeUnitMeasureInstance">UnitMeasureEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="weightUnitMeasureInstance">UnitMeasureEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		public int UpdateMultiManyToOne(ProductEntity entityWithNewValues, IEntity productModelInstance, IEntity productSubcategoryInstance, IEntity sizeUnitMeasureInstance, IEntity weightUnitMeasureInstance)
		{
			return DAOFactory.CreateProductDAO().UpdateMulti(entityWithNewValues, this.Transaction, productModelInstance, productSubcategoryInstance, sizeUnitMeasureInstance, weightUnitMeasureInstance);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  Relation of type 'm:n' with the passed in ProductPhotoEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="productPhotoInstance">ProductPhotoEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingPhotos(IEntity productPhotoInstance)
		{
			return GetMultiManyToManyUsingPhotos(productPhotoInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  relation of type 'm:n' with the passed in ProductPhotoEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="productPhotoInstance">ProductPhotoEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingPhotos(IEntity productPhotoInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingPhotos(productPhotoInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a Relation of type 'm:n' with the passed in ProductPhotoEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="productPhotoInstance">ProductPhotoEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingPhotos(IEntity productPhotoInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingPhotos(productPhotoInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, prefetchPathToUse);
		}
		
		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  relation of type 'm:n' with the passed in ProductPhotoEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="productPhotoInstance">ProductPhotoEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingPhotos(IEntity productPhotoInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateProductDAO().GetMultiUsingPhotos(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, productPhotoInstance, null, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  relation of type 'm:n' with the passed in ProductPhotoEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="productPhotoInstance">ProductPhotoEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingPhotos(IEntity productPhotoInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateProductDAO().GetMultiUsingPhotos(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, productPhotoInstance, prefetchPathToUse, 0, 0);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  Relation of type 'm:n' with the passed in SpecialOfferEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="specialOfferInstance">SpecialOfferEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingSpecialOffers(IEntity specialOfferInstance)
		{
			return GetMultiManyToManyUsingSpecialOffers(specialOfferInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  relation of type 'm:n' with the passed in SpecialOfferEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="specialOfferInstance">SpecialOfferEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingSpecialOffers(IEntity specialOfferInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingSpecialOffers(specialOfferInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a Relation of type 'm:n' with the passed in SpecialOfferEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="specialOfferInstance">SpecialOfferEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingSpecialOffers(IEntity specialOfferInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingSpecialOffers(specialOfferInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, prefetchPathToUse);
		}
		
		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  relation of type 'm:n' with the passed in SpecialOfferEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="specialOfferInstance">SpecialOfferEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingSpecialOffers(IEntity specialOfferInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateProductDAO().GetMultiUsingSpecialOffers(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, specialOfferInstance, null, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  relation of type 'm:n' with the passed in SpecialOfferEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="specialOfferInstance">SpecialOfferEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingSpecialOffers(IEntity specialOfferInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateProductDAO().GetMultiUsingSpecialOffers(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, specialOfferInstance, prefetchPathToUse, 0, 0);
		}

		/// <summary> Retrieves Entity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		/// <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>DataTable with the rows requested.</returns>
		public static DataTable GetMultiAsDataTable(IPredicate selectFilter, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiAsDataTable(selectFilter, maxNumberOfItemsToReturn, sortClauses, null, 0, 0);
		}

		/// <summary> Retrieves Entity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		/// <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="relations">The set of relations to walk to construct to total query.</param>
		/// <returns>DataTable with the rows requested.</returns>
		public static DataTable GetMultiAsDataTable(IPredicate selectFilter, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IRelationCollection relations)
		{
			return GetMultiAsDataTable(selectFilter, maxNumberOfItemsToReturn, sortClauses, relations, 0, 0);
		}
		
		/// <summary> Retrieves Entity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		/// <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="relations">The set of relations to walk to construct to total query.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>DataTable with the rows requested.</returns>
		public static DataTable GetMultiAsDataTable(IPredicate selectFilter, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IRelationCollection relations, int pageNumber, int pageSize)
		{
			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.GetMultiAsDataTable(maxNumberOfItemsToReturn, sortClauses, selectFilter, relations, pageNumber, pageSize);
		}


		
		/// <summary> Gets a scalar value, calculated with the aggregate. the field index specified is the field the aggregate are applied on.</summary>
		/// <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		/// <param name="aggregateToApply">Aggregate function to apply. </param>
		/// <returns>the scalar value requested</returns>
		public object GetScalar(ProductFieldIndex fieldIndex, AggregateFunction aggregateToApply)
		{
			return GetScalar(fieldIndex, null, aggregateToApply, null, null, null);
		}

		/// <summary> Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		/// <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		/// <param name="expressionToExecute">The expression to execute. Can be null</param>
		/// <param name="aggregateToApply">Aggregate function to apply. </param>
		/// <returns>the scalar value requested</returns>
		public object GetScalar(ProductFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply)
		{
			return GetScalar(fieldIndex, expressionToExecute, aggregateToApply, null, null, null);
		}

		/// <summary> Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		/// <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		/// <param name="expressionToExecute">The expression to execute. Can be null</param>
		/// <param name="aggregateToApply">Aggregate function to apply. </param>
		/// <param name="filter">The filter to apply to retrieve the scalar</param>
		/// <returns>the scalar value requested</returns>
		public object GetScalar(ProductFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply, IPredicate filter)
		{
			return GetScalar(fieldIndex, expressionToExecute, aggregateToApply, filter, null, null);
		}

		/// <summary> Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		/// <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		/// <param name="expressionToExecute">The expression to execute. Can be null</param>
		/// <param name="aggregateToApply">Aggregate function to apply. </param>
		/// <param name="filter">The filter to apply to retrieve the scalar</param>
		/// <param name="groupByClause">The groupby clause to apply to retrieve the scalar</param>
		/// <returns>the scalar value requested</returns>
		public object GetScalar(ProductFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply, IPredicate filter, IGroupByCollection groupByClause)
		{
			return GetScalar(fieldIndex, expressionToExecute, aggregateToApply, filter, null, groupByClause);
		}

		/// <summary> Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		/// <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		/// <param name="expressionToExecute">The expression to execute. Can be null</param>
		/// <param name="aggregateToApply">Aggregate function to apply. </param>
		/// <param name="filter">The filter to apply to retrieve the scalar</param>
		/// <param name="relations">The relations to walk</param>
		/// <param name="groupByClause">The groupby clause to apply to retrieve the scalar</param>
		/// <returns>the scalar value requested</returns>
		public virtual object GetScalar(ProductFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply, IPredicate filter, IRelationCollection relations, IGroupByCollection groupByClause)
		{
			EntityFields fields = new EntityFields(1);
			fields[0] = EntityFieldFactory.Create(fieldIndex);
			if((fields[0].ExpressionToApply == null) || (expressionToExecute != null))
			{
				fields[0].ExpressionToApply = expressionToExecute;
			}
			if((fields[0].AggregateFunctionToApply == AggregateFunction.None) || (aggregateToApply != AggregateFunction.None))
			{
				fields[0].AggregateFunctionToApply = aggregateToApply;
			}
			return DAOFactory.CreateProductDAO().GetScalar(fields, this.Transaction, filter, relations, groupByClause);
		}
		
		/// <summary>Creats a new DAO instance so code which is in the base class can still use the proper DAO object.</summary>
		protected override IDao CreateDAOInstance()
		{
			return DAOFactory.CreateProductDAO();
		}
		
		/// <summary>Creates a new transaction object</summary>
		/// <param name="levelOfIsolation">The level of isolation.</param>
		/// <param name="name">The name.</param>
		protected override ITransaction CreateTransaction( IsolationLevel levelOfIsolation, string name )
		{
			return new Transaction(levelOfIsolation, name);
		}

		#region Custom EntityCollection code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCollectionCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		#region Included Code

		#endregion
	}
}
