# copilot-instructions.md

## Project Overview
This project is a .NET (C#) microservice MCP server for managing students, providing CRUD operations. It uses the [Model Context Protocol (MCP)](https://modelcontextprotocol.io/) and the official [C# SDK](https://github.com/modelcontextprotocol/csharp-sdk).

## References
- [MCP Documentation](https://modelcontextprotocol.io/)
- [C# SDK for MCP](https://github.com/modelcontextprotocol/csharp-sdk)
- [MCP Specification](https://modelcontextprotocol.io/specification/latest)

## Setup Steps
1. Scaffold a .NET Web API project for students CRUD.
2. Integrate the MCP C# SDK as per [csharp-sdk instructions](https://github.com/modelcontextprotocol/csharp-sdk).
3. Implement endpoints for Create, Read, Update, Delete student records.
4. Add a DbContext and Student model.
5. Configure the MCP server entry in `.vscode/mcp.json`.
6. Install the C# extension for VS Code if not already present.

## Notes
- Use an in-memory database for simplicity.
- Follow best practices for .NET Web API and MCP integration.
