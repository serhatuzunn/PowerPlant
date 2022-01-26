call "node_modules\.bin\nswag" run /runtime:Net50 /variables:Input="https://localhost:44354/swagger/v1/swagger.json",Output="src/shared/service-proxies.ts",BaseUrlToken="API_BASE_URL"

