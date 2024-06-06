export const Api = {
    call(url, method, body = {}) {
        const token = btoa("user:user");
        const data = {
            method,
            credentials: 'include',
            headers: {
                "Accept": 'application/json',
                "Content-Type": 'application/json',
                "Access-Control-Allow-Origin": 'https://localhost',
                "Authorization": `Basic ${token}`,
                "Authentication": 'Basic realm="rndcdemo"'
            },
        };

        if (Object.keys(body).length > 0) {
            data.body = JSON.stringify(body);
        }

        return fetch(url, data).then(response => {
            if (!response.ok) {
                throw `Server error: [${response.status}] [${response.statusText}] [${response.url}]`;
            }
            return response.json();
        });
    },

    get(url) {
        return this.call(url, 'get');
    },

    post(url, body = {}) {
        return this.call(url, 'post', body);
    },

    delete(url) {
        return this.call(url, 'delete');
    },
};