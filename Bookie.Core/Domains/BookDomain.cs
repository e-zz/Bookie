﻿namespace Bookie.Core.Domains
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using Common.Model;
    using Data.Interfaces;
    using Data.Repositories;
    using Interfaces;

    public class BookDomain : IBookDomain
    {
        private readonly IBookRepository _bookRepository;

        public BookDomain()
        {
            _bookRepository = new BookRepository();
        }

        public IList<Book> GetAllBooks()
        {
            var s = _bookRepository.GetAll(a => a.BookFile, b => b.CoverImage, c => c.BookHistory, d => d.Publishers,
                e => e.Authors, f => f.BookMarks, g => g.Notes, h => h.SourceDirectory);
            return s;
        }

        public Book GetBookByTitle(string title)
        {
            return
                _bookRepository.GetAll(a => a.BookFile, b => b.CoverImage, c => c.BookHistory, d => d.Publishers,
                    e => e.Authors, f => f.BookMarks, g => g.Notes, h => h.SourceDirectory)
                    .Single(x => x.Title.Equals(title));
        }

        public Book GetBookById(int id)
        {
            return
                _bookRepository.GetAll(a => a.BookFile, b => b.CoverImage, c => c.BookHistory, d => d.Publishers,
                    e => e.Authors, f => f.BookMarks, g => g.Notes, h => h.SourceDirectory).Single(x => x.Id.Equals(id));
        }

        Book IBookDomain.SetUnchanged(Book book)
        {
            return SetUnchanged(book);
        }

        public void AddBook(params Book[] books)
        {
            if (Exists(books[0].BookFile.FullPathAndFileNameWithExtension))
            {
                return;
            }

            _bookRepository.Add(books);
        }

        public void UpdateBook(params Book[] book)
        {
            _bookRepository.Update(book);
        }

        public void RemoveBook(params Book[] book)
        {
            var coverPath = book[0].CoverImage.FullPathAndFileNameWithExtension;
            book[0].EntityState = EntityState.Deleted;
            book[0].BookFile.EntityState = EntityState.Deleted;
            book[0].BookHistory.EntityState = EntityState.Deleted;
            book[0].CoverImage.EntityState = EntityState.Deleted;
            book[0].SourceDirectory.EntityState = EntityState.Unchanged;
            if (File.Exists(coverPath))
            {
                File.Delete(coverPath);
            }

            foreach (var b in book[0].BookMarks)
            {
                b.EntityState = EntityState.Deleted;
            }
            foreach (var b in book[0].Notes)
            {
                b.EntityState = EntityState.Deleted;
            }
            //foreach (var b in book[0].Authors)
            //{
            //    b.EntityState = EntityState.Deleted;
            //}
            //foreach (var b in book[0].Publishers)
            //{
            //    b.EntityState = EntityState.Deleted;
            //}

            book[0].EntityState = EntityState.Deleted;
            _bookRepository.Remove(book);
        }

        public bool Exists(string filePath)
        {
            return _bookRepository.Exists(filePath);
        }

        public async Task<IList<Book>> GetAllAsync()
        {
            var s = _bookRepository.GetAllAsync(a => a.BookFile, b => b.CoverImage, c => c.BookHistory,
                d => d.SourceDirectory, e => e.Publishers, f => f.Authors, g => g.BookMarks, h => h.Notes);
            return await s;
        }

        public IList<Book> GetNested()
        {
            return _bookRepository.GetAllNested();
        }

        public static Book SetUnchanged(Book book)
        {
            foreach (var x in book.BookMarks)
            {
                x.EntityState = EntityState.Unchanged;
            }
            foreach (var publisher in book.Publishers)
            {
                publisher.EntityState = EntityState.Unchanged;
            }
            foreach (var author in book.Authors)
            {
                author.EntityState = EntityState.Unchanged;
            }
            foreach (var n in book.Notes)
            {
                n.EntityState = EntityState.Unchanged;
            }
            book.SourceDirectory.EntityState = EntityState.Unchanged;
            book.BookFile.EntityState = EntityState.Unchanged;
            book.BookHistory.EntityState = EntityState.Unchanged;
            book.CoverImage.EntityState = EntityState.Unchanged;
            return book;
        }
    }
}