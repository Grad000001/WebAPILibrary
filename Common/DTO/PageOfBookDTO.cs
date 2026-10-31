namespace WebAPILibrary.Common.DTO
{
    public record PageOfBookDTO(Guid IdBook, string Name, Page Page, int CountPage);
}
