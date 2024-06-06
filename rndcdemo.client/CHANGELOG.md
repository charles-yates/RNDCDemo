This file explains how Visual Studio created the project.

The following tools were used to generate this project:
- create-vite

The following steps were used to generate this project:
- Create react project with create-vite: `npm init --yes vite@latest rndcdemo.client -- --template=react`.
- Update `vite.config.js` to set up proxying and certs.
- Update `App` component to fetch and display product information.
- Create project file (`rndcdemo.client.esproj`).
- Create `launch.json` to enable debugging.
- Create `nuget.config` to specify location of the JavaScript Project System SDK (which is used in the first line in `rndcdemo.client.esproj`).
- Add project to solution.
- Update proxy endpoint to be the backend server endpoint.
- Add project to the startup projects list.
- Write this file.
