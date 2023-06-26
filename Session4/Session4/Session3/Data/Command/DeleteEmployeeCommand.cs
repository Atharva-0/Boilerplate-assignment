using MediatR;

namespace Session3.Data.Command
{
    public class DeleteEmployeeCommand:IRequest<int>
    {
        public int Id { get; set; }
    }
}
