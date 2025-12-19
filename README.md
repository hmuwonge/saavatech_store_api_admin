# saavatech_store_api_admin
# E-Commerce Web API + Admin Dashboard

This project is a **full-stack e-commerce solution** built with:

- **ASP.NET Core Web API** (`Ecommerce.Api`)
- **Blazor Server Admin Dashboard** (`Ecommerce.Admin`)
- **Tailwind CSS** for styling
- **Aspire Framework** for modular architecture and DI
- **JWT Authentication** for secure API access
- **PostgreSQL** as database
- **Docker & Docker Compose** for development and production

---

## 📁 Project Structure


---

## ⚡ Prerequisites

- macOS or Linux
- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [Docker Desktop](https://www.docker.com/products/docker-desktop/)
- [Node.js & npm](https://nodejs.org/) (for Tailwind CSS)

Verify installations:

```bash
dotnet --version
docker --version
docker compose version
node -v
npm -v
```

🐳 Docker Setup

Navigate to project root:
``` bash
cd ecommerce
```

Build and run containers:
```bash
docker compose up --build
```

| Service         | URL                                            |
| --------------- | ---------------------------------------------- |
| API             | [http://localhost:5000](http://localhost:5000) |
| Admin Dashboard | [http://localhost:5001](http://localhost:5001) |
| PostgreSQL      | localhost:5432                                 |

⚙️ API Configuration
Connection String

The API expects PostgreSQL connection string in environment variables:

```yaml
api:
  environment:
    ConnectionStrings__Default: "Host=postgres;Port=5432;Database=ecommerce;Username=ecommerce;Password=secret"
    Jwt__Key: "SUPER_SECRET_KEY_12345"
    Jwt__Issuer: "Ecommerce.Api"
    Jwt__Audience: "Ecommerce.Admin"

```
Database Migrations

Run migrations locally:
```bash
dotnet ef migrations add InitialCreate -p Ecommerce.Api
dotnet ef database update -p Ecommerce.Api
```

Or inside Docker container:
```bash
Copy code
docker exec -it ecommerce-api dotnet ef database update
```
🎨 Tailwind CSS Setup

Navigate to Ecommerce.Admin:
```bash
cd Ecommerce.Admin

```

Install dependencies:
```bash
npm install -D tailwindcss postcss autoprefixer
npx tailwindcss init
```

Configure tailwind.config.js:
```javascript
module.exports = {
content: ['./**/*.razor', './wwwroot/index.html', './Pages/**/*.razor', './Shared/**/*.razor'],
theme: { extend: {} },
plugins: [],
}
```
Create CSS file wwwroot/css/site.css:

```css
@tailwind base;
@tailwind components;
@tailwind utilities;

```

Build Tailwind CSS:
```bash
npm run build:css

```

Include CSS in _Host.cshtml:
```bash
<link href="css/output.css" rel="stylesheet" />

```

✅ Running the Project

Start Docker containers:

```bash
docker compose up --build

```

Build Tailwind CSS for admin:
```bash
cd Ecommerce.Admin
npm run build:css

```

Navigate to Admin Dashboard: http://localhost:5001

API available at: http://localhost:5000