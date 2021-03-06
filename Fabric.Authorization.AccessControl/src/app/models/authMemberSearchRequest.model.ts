export type SortDirection = 'asc' | 'ascending' | 'desc' | 'descending';
export type SortKey = 'name' | 'role' | 'lastlogin' | 'subjectid';

export interface IAuthMemberSearchRequest {
  pageNumber?: number;
  pageSize?: number;
  filter?: string;
  sortKey?: SortKey;
  sortDirection?: SortDirection;

  /** if omitted, must provide `grain` */
  clientId?: string;
  /** if omitted, must provide `clientId` */
  grain?: string;
  securableItem?: string;
}
