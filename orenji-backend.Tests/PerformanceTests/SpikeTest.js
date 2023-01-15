import http from 'k6/http';
import {sleep, check} from 'k6';

export const options = {
    stages: [
        { duration: '20s', target: 10 },
        { duration: '5s', target: 300 },
        { duration: '20s', target: 10 },
        { duration: '5s', target: 400 },
        { duration: '20s', target: 10 },
    ],
    thresholds: {
        http_req_failed: ['rate<0.01'],
    },
};

const base_url = 'http://localhost:6000'
export default () => {
    const responses = http.batch([
        ['GET', `${base_url}/tutorial/start/a`]
    ])
    check(responses[0], {
        'status is' : res => res.status === 200
    })
    sleep(1);
}