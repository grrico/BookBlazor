﻿using BookApp.Interfaces;
using BookApp.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
namespace BookApp.Data
{
    public class BookAuthorService : IBookAuthorService
    {
        private readonly IDapperService _dapperService;
        public BookAuthorService(IDapperService dapperService)
        {
            this._dapperService = dapperService;
        }

        /// <summary>
        /// Crea un autor
        /// </summary>
        /// <param name="bookAuthorName"></param>
        /// <returns></returns>
        public Task<int> Create(BookAuthorName bookAuthorName)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("ISBN", bookAuthorName.ISBN, DbType.Int64);
            dbPara.Add("AuthorId", bookAuthorName.AuthorId,DbType.Int32);
            dbPara.Add("AuthorOrd", bookAuthorName.AuthorOrd,DbType.Byte);
            
            var bookAuthorId = Task.FromResult(_dapperService.
                Insert<int>("[dbo].[spAddBookAuthor]", dbPara,commandType: CommandType.StoredProcedure));
            return bookAuthorId;
        }
        /// <summary>
        /// Eliminar autor
        /// </summary>
        /// <param name="isbn"></param>
        /// <param name="authorId"></param>
        /// <returns></returns>
        public Task<int> Delete(long isbn, int authorId)
        {
            var deleteBookAuthor = Task.FromResult(_dapperService.
                Execute($"Delete [BookAuthor] where ISBN = {isbn} and AuthorId = {authorId}", null,
                commandType: CommandType.Text));
            return deleteBookAuthor;
        }

        /// <summary>
        /// Obtener todo
        /// </summary>
        /// <param name="isbn"></param>
        /// <returns></returns>
        public Task<List<BookAuthorName>> FetchAll(long isbn)
        {
            var bookAuthorNames = Task.FromResult(_dapperService.GetAll
                <BookAuthorName>($"select * from BookAuthorName ({isbn}) order by AuthorName; ", null,
                commandType: CommandType.Text));
            return bookAuthorNames;
        }
    }
}