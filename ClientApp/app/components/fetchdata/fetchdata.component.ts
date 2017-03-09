import { Component } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'fetchdata',
    templateUrl: './fetchdata.component.html'
})
export class FetchDataComponent {
    public photos: Photo[];

    constructor(http: Http) {
        http.get('/api/SampleData/Photos').subscribe(result => {
            this.photos = result.json() as Photo[];
        });
    }
}

interface Photo {
    id: number;
    name: string;
}
