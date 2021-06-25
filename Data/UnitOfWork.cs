using System.Threading.Tasks;
using Data.Interfaces;

namespace Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LibraryDbContext _context;

        public UnitOfWork(LibraryDbContext context, IBookRepository bookRepository, 
            ICardRepository cardRepository, IHistoryRepository historyRepository, 
            IReaderRepository readerRepository)
        {
            _context = context;
            CardRepository = cardRepository;
            HistoryRepository = historyRepository;
            ReaderRepository = readerRepository;
            BookRepository = bookRepository;
        }

        public IBookRepository BookRepository { get; }
        public ICardRepository CardRepository { get; }
        public IHistoryRepository HistoryRepository { get; }
        public IReaderRepository ReaderRepository { get; }
        
        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}