using Volo.Abp.Application.Dtos;

namespace BookStore.Books
{
    public class BookGetListInput : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}