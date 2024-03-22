namespace Catalog.API.Products.CreateProduct;

public record CreateProductCommand(string Name, List<string> Category, string Summary, string Description, string ImageFile, decimal Price)
    : ICommand<CreateProductResult>;
public record CreateProductResult(string Id);

internal class CreateProductCommandHandler (IDocumentSession session)
    : ICommandHandler<CreateProductCommand, CreateProductResult>
{
    public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        // Create a product entity from incoming command
        var product = new Product
        {
            Name = command.Name,
            Category = command.Category,
            Summary = command.Summary,
            Description = command.Description,
            ImageFile = command.ImageFile,
            Price = command.Price
        };

        // Save to database
        session.Store(product);
        await session.SaveChangesAsync(cancellationToken);

        // Return the result
        return new CreateProductResult(product.Id);
    }
}
